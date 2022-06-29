using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlannerCeeSharp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace WeddingPlannerCeeSharp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }


    //Login and Reistration is our index page
    public IActionResult Index()
    {
        return View();
    }

    //Submitting the register form
    [HttpPost("user/register")]
    public IActionResult Register(User newUser)
    {
        if(ModelState.IsValid)
        {
            //check if the email has been used already
            if(_context.Users.Any(u => u.Email == newUser.Email))
            {
                //Problem: A user exists that has this email already
                ModelState.AddModelError("Email", "Email already in use!");
                return View("Index");
            }
            //validation passed
            //then we hash the password
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            _context.Add(newUser);
            _context.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            return RedirectToAction("Dashboard");
        } else {
            return View("Index");
        }
    } 
    //Submitting the login info
    [HttpPost("user/login")]
    public IActionResult Login(LogUser loginUser)
    {
        if(ModelState.IsValid)
        {
            //Verify that the email is in the database
            User? userInDb = _context.Users.FirstOrDefault(u => u.Email == loginUser.LogEmail);
            if(userInDb == null)
            {
                //Email did not match any in db
                ModelState.AddModelError("LogEmail", "Invalid Login Attempt!");
                return View("Index");
            }
            //Email does match
            //then verify the password is correct
            PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
            var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LogPassword);
            if(result == 0)
            {
                //Problem: Wrong password
                ModelState.AddModelError("LogEmail", "Invalid Login Attempt");
                return View("Index");
            } else {
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
        } else {
            return View("Index");
        }
    }

    //Go to the dashboard after register or login
    [HttpGet("Dashboard")]
    public IActionResult Dashboard()
    {
        if(HttpContext.Session.GetInt32("UserId") == null){
            return RedirectToAction("Index");
        }
        
        List<Wedding> AllWeddings = _context.Weddings.Include(i => i.UsersWhoRSVPed).ToList();

        User? userInDb = _context.Users.FirstOrDefault(a => a.UserId == HttpContext.Session.GetInt32("UserId"));
        ViewBag.LoggedIn = userInDb;
        return View(AllWeddings);
    }
    
    //Button on the dashboard that goes to make a AddWedding page
    [HttpGet("addAWedding")]
    public IActionResult AddAWedding()
    {
        if(HttpContext.Session.GetInt32("UserId") == null){
            return RedirectToAction("Index");
        }
        User loggedInUser = _context.Users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId"));
        return View("AddWedding");
    }
    
    //Actually creating the new wedding on the AddWedding page
    [HttpPost("add/wedding")]
    public IActionResult AddWedding(Wedding newWedding)
    {
        if(HttpContext.Session.GetInt32("UserId") == null){
            return RedirectToAction("Index");
        }
        if(ModelState.IsValid)
        {
            //we can add to db
            newWedding.UserId =(int)HttpContext.Session.GetInt32("UserId");
            
            _context.Add(newWedding);
            _context.SaveChanges();
            return Redirect($"/wedding/{newWedding.WeddingId}");
        } else {
            ViewBag.AllWeddings = _context.Weddings.OrderByDescending(d => d.CreatedAt).ToList();
            return View("AddWedding");
        }
    }
    
    [HttpGet("wedding/{WeddingId}")]
    public IActionResult ViewWedding(int weddingId)
    {
        if(HttpContext.Session.GetInt32("UserId") == null){
            return RedirectToAction("Index");
        }
        Wedding? weddingToView = _context.Weddings.Include(b => b.UsersWhoRSVPed).ThenInclude(c => c.UserWhoRSVPed).FirstOrDefault(a => a.WeddingId == weddingId);
        if(weddingToView == null) {
            RedirectToAction("Dashboard");
        }
        ViewBag.OneWedding = weddingToView;
        return View();
    }

    //delete a wedding
    [HttpGet("delete/wedding/{WeddingId}")]
    public IActionResult DeleteWedding(int weddingId)
    {
        Wedding? retrievedWedding = _context.Weddings.SingleOrDefault(dw => dw.WeddingId == weddingId);
        if(retrievedWedding == null) {
            return RedirectToAction("Dashboard");
        }
        if(retrievedWedding.UserId != HttpContext.Session.GetInt32("UserId"))
        {
            return RedirectToAction("LogoutUser");
        }
        _context.Weddings.Remove(retrievedWedding);
        _context.SaveChanges();
        return RedirectToAction("Dashboard");
    }

    [HttpGet("wedding/RSVP/{WeddingId}")]
    public IActionResult RSVPWedding(int weddingId)
    {
        if(HttpContext.Session.GetInt32("UserId") == null){
            return RedirectToAction("Index");
        }
        RSVP newRSVP = new RSVP()
        {
            UserId = (int)HttpContext.Session.GetInt32("UserId"),
            WeddingId = weddingId
        };
        _context.Add(newRSVP);
        _context.SaveChanges();
        return RedirectToAction("Dashboard");
    }
    
    [HttpGet("delete/RSVP/{WeddingId}")]
    public IActionResult DeleteRSVP(int WeddingId)
    {
        RSVP? retrievedRSVP = _context.RSVPs.SingleOrDefault(r => r.WeddingId == WeddingId && r.UserId == (int)HttpContext.Session.GetInt32("UserId"));
        if(retrievedRSVP == null) {
            return RedirectToAction("Dashboard");
        }
        
        _context.RSVPs.Remove(retrievedRSVP);
        _context.SaveChanges();
        return RedirectToAction("Dashboard");
    }
    
    //Logout Buttons
    [HttpGet("LogoutUser")]
    public IActionResult LogoutUser()
    {

        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    //We are not altering things below here
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
