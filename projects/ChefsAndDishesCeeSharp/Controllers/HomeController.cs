using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishesCeeSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishesCeeSharp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    // This page displays all chefs and has button to navigate to create a chef
    public IActionResult Index()
    {
        ViewBag.AllChefs = _context.Chefs.OrderByDescending(d => d.CreatedAt).ToList();

        return View();
    }
    //Add a chef button on the Index page
    [HttpGet("addAChef")]
    public IActionResult AddAChef()
    {
        return View("AddChef");
    }
    //Actually adding the chef to the database from the AddChef page
    [HttpPost("add/chef")]
    public IActionResult AddChef(Chef newChef)
    {
        if(ModelState.IsValid)
        {
            //we can add to db
            _context.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index");
        } else {
            return View("AddChef");
        }
    }
    //View the dishes page button on Index
    [HttpGet("seeDishes")]
    public IActionResult SeeTheDishes()
    {
        ViewBag.AllDishes = _context.Dishes.Include(o => o.Creator).OrderByDescending(d => d.CreatedAt).ToList();
        
        return View("Dishes");
    }
    //Add a dish button on the Dishes page
    [HttpGet("addADish")]
    public IActionResult AddADish()
    {
        ViewBag.AllChefs = _context.Chefs.OrderByDescending(d => d.CreatedAt).ToList();
        return View("AddDish");
    }
    //Actually adding the dish to the database from the AddDish page
    [HttpPost("add/dish")]
    public IActionResult AddDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            //we can add to db
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("seeTheDishes");
        } else {
            ViewBag.AllChefs = _context.Chefs.OrderByDescending(d => d.CreatedAt).ToList();
            return View("AddDish");
        }
    }








    //Stuff we are not altering currently
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
