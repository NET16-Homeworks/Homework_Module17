using Microsoft.AspNetCore.Mvc;

namespace Homework_Module17.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}