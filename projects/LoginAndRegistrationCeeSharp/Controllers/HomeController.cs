using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginAndRegistrationCeeSharp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginAndRegistrationCeeSharp.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HttpContext.Session.Clear();
        return View();
    }

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
            HttpContext.Session.SetInt32("user", newUser.UserId);
            return RedirectToAction("Success");
        } else {
            return View("Index");
        }
    }

    [HttpPost("user/login")]
    public IActionResult Login(LogUser loginUser)
    {
        if(ModelState.IsValid)
        {
            // Step 1: find email, throw an error if it is not in db
            User userInDb = _context.Users.FirstOrDefault(a => a.Email == loginUser.LogEmail);
            if( userInDb == null)
            {
                //there was no email that matched
                ModelState.AddModelError("LogEmail", "Invalid Login Attempt");
                return View("Index");
            }
            PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
            var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LogPassword);
            if(result == 0)
            {
                //Problem: Wrong password
                ModelState.AddModelError("LogEmail", "Invalid Login Attempt");
                return View("Index");
            } else {
                HttpContext.Session.SetInt32("user", userInDb.UserId);
                return RedirectToAction("Success");
            }            
        } else {
            return View("Index");
        }
    }


    [HttpGet("success")]
    public IActionResult Success()
    {
        if(HttpContext.Session.GetInt32("user") == null){
            return RedirectToAction("Index");
        }
        User loggedInUser = _context.Users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("user"));
        return View(loggedInUser);
    }
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
