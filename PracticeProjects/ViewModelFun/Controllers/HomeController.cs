using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string Message = "Here is a new message.";
        return View("Index", Message);
    }
    [HttpGet("numbers")]
    public IActionResult numbers()
    {
        int[] numberArray = {2,4,6,8,10};
        return View(numberArray);
    }
    [HttpGet("users")]
    public IActionResult users()
    {
        List<User> userList = new List<User>()
        {
            new User{FirstName = "Jeff", LastName = "Davison"}, 
            new User{FirstName = "Logan", LastName = "Goofy"}, 
            new User{FirstName = "George", LastName = "Foreman"}, 
            new User{FirstName = "Mike", LastName = "Tyson"} 
        };
        return View(userList);
    }
    [HttpGet("userPage")]
    public IActionResult userPage()
    {
        User oneUser = new User{FirstName = "Jeff", LastName = "Davison"} ;
        return View(oneUser);
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