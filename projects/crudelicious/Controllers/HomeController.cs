using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using crudelicious.Models;

namespace crudelicious.Controllers;

public class HomeController : Controller
{
    private MyContext _context;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        //establishes connection to db
        _context = context;
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
    public IActionResult Index()
    {
        ViewBag.AllDishes = _context.Dishes.OrderByDescending(d => d.CreatedAt).ToList();
        return View();
    }

    [HttpGet("new")]
    public IActionResult New()
    {
        return View("NewDish");
    }        
    
    [HttpPost("newDish")]
    public IActionResult NewDish(Dish newdish)
    {
        if(ModelState.IsValid)
        {
        _context.Add(newdish);
        _context.SaveChanges();
        return RedirectToAction("Index");
        } else {
            return View("NewDish");
        }
    }

    [HttpGet("/see/{dishId}")]
    public IActionResult ViewDish(int dishId)
    {
        Dish retrievedDish = _context.Dishes.SingleOrDefault(di => di.DishId == dishId);
        return View("ViewDish", retrievedDish);
    }

    [HttpGet("delete/{dishId}")]
    public IActionResult DeleteDish(int dishId)
    {
        Dish retrievedDish = _context.Dishes.SingleOrDefault(di => di.DishId == dishId);
        _context.Dishes.Remove(retrievedDish);
        _context.SaveChanges();
        return RedirectToAction("Index", retrievedDish); 
    }

    [HttpPost("dish/update/{dishId}")]
    public IActionResult UpdateDish(int dishId, Dish newVersionOfDish)
    {
        Dish oldDish = _context.Dishes.FirstOrDefault(b => b.DishId == dishId);
        oldDish.DishName = newVersionOfDish.DishName;
        oldDish.ChefsName = newVersionOfDish.ChefsName;
        oldDish.Description = newVersionOfDish.Description;
        oldDish.Calories = newVersionOfDish.Calories;
        oldDish.Tastiness = newVersionOfDish.Tastiness;
        oldDish.UpdatedAt = DateTime.Now;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet("edit/{dishId}")]
    public IActionResult EditDish(int dishId)
    {
        Dish dishToEdit = _context.Dishes.FirstOrDefault(a => a.DishId == dishId);
        return View(dishToEdit);
    }
}
