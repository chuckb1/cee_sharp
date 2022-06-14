using Microsoft.AspNetCore.Mvc;
namespace realDojoSurvey.Controllers;

public class NinjaController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(string NinjaName, string Location, string FavLanguage, string Comment)
    {
        Console.WriteLine($"Name: {NinjaName}");
        Console.WriteLine($"Favorite programming language: {FavLanguage}");
        ViewBag.NinjaName = NinjaName;
        ViewBag.Location = Location;
        ViewBag.FavLanguage = FavLanguage;
        ViewBag.Comment = Comment;
        return View("Index1");
    }

    [HttpGet("Index1")]
    public ViewResult Submitted()
    {
        return View();
    }
}