using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using View_model_fun.Models;

namespace View_model_fun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        string message = "This is my message from controller";
        return View("myViewModel", message);
    }

    [HttpGet("numbers")]
    public IActionResult Number()
    {
        List<int> myNumberModel = new List<int>() {1,2,3,4,5,6};
        return View("myNumberModel", myNumberModel);
    }

    [HttpGet("user")]
    public IActionResult ThisUser()
    {
        User OneUser = new User()
        {
            FirstName = "Saul",
            LastName = "Goodman"
        };
        return View("myUserModel", OneUser);
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
        List<User> ListOfUsers = new List<User>()
        {
            new User() {FirstName = "Jesse", LastName = "Pinkman"},
            new User() {FirstName = "Walter",LastName = "White"}
        };
        return View("myUsersModel", ListOfUsers);
    }

    [HttpGet("privacy")]
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
