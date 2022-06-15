#pragma warning disable CS8618
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        if(HttpContext.Session.GetInt32("count") == null)
        {
            HttpContext.Session.SetInt32("count", 0);
        }
        ViewBag.count = HttpContext.Session.GetInt32("count");
        return View();
    }
    [HttpGet("RandGenNum")]
    public IActionResult RandGenNum()
    {
    Random res = new Random();
    // String that contain both alphabets and numbers
    string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    int size = 14;
    // Initializing the empty string
    string randomstring = "";
    for (int i = 0; i < size; i++)
    {
        // Selecting a index randomly
        int x = res.Next(str.Length);
        // Appending the character at the 
        // index to the random alphanumeric string.
        randomstring = randomstring + str[x];
    }
    //count how many strings
    //y++ when generate button is clicked
    //session set get y
    Console.WriteLine("Random alphanumeric String:" + randomstring);
    HttpContext.Session.SetString("RandGenNum",randomstring);
    string? thething = HttpContext.Session.GetString("RandGenNum");
    int? number = HttpContext.Session.GetInt32("count");
    int newNum = number ?? default(int);
    HttpContext.Session.SetInt32("count", newNum+1);

    Console.WriteLine(thething);

    return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }    
}
