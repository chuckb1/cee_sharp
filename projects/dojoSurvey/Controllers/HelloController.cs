using Microsoft.AspNetCore.Mvc;
namespace dojoSurvey.Controllers;     //be sure to use your own project's namespace!
public class HelloController : Controller   //remember inheritance??
{
    //for each route this controller is to handle:
    [HttpGet]       //type of request
    [Route("")]     //associated route string (exclude the leading /)
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("second")]
    public ViewResult Second()
    {
        return View("Second");
    }

    [HttpGet("third/{name}")]
    public ViewResult NameRoute(string name)
    {
        ViewBag.Name = name;
        ViewBag.MyArray = new int[5] {1,2,3,4,5};
        ViewBag.MyArray2 = new string[5] {"here", "are", "my", "five", "strings"};
        return View("Third");
    }
}
