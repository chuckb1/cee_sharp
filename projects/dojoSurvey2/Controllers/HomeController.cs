using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dojoSurvey2.Models;

namespace dojoSurvey2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    //Ninja Control
    [HttpPost("process")]
    public IActionResult Process(Ninja  newNinja)
    {
        if(ModelState.IsValid)
        {
            //this means we passed validations
            //then we go to Index1
            return RedirectToAction("Index1", newNinja);
        } 
        else 
        {
            //what to do if there is an validation error
            return View("Index");
        }
    }
    //Index1
    [HttpGet("Index1")]
    public IActionResult Index1(Ninja newNinja)
    {
        return View(newNinja);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
