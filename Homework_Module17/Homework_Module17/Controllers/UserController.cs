using Microsoft.AspNetCore.Mvc;
using Homework_Module17.ViewModels;
using Homework_Module17.Services;

namespace Homework_Module17.Controllers
{
    public class UserController : Controller
    {
        UserService userService = new UserService();

        public IActionResult Index()
        {
            return View(userService.GetUsers());
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(UserViewModel user)
        {
            userService.AddUser(user);
            return RedirectToAction("Index");
        }

        public IActionResult _GoBack()
        {
            return PartialView();
        }

        public IActionResult GetUser(int id = 0)
        {
            return View(id);
        }

        [HttpGet]
        public IActionResult DeleteUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteUser(int id)
        {
            userService.DeleteUser(id);
            return RedirectToAction("Index");
        }
    }
}
