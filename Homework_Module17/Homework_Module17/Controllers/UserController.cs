using Microsoft.AspNetCore.Mvc;
using Homework_Module17.Services;
using Homework_Module17.Models;

namespace Homework_Module17.Controllers
{
    public class UserController : Controller
    {
        //public static readonly UserService userService = new UserService();
        public IActionResult Index()
        {
            return View(UserService.GetUsers());
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(UserViewModel user)
        {
            UserService.AddUser(user);
            return RedirectToAction("Index");
        }

        public IActionResult GetUser(int index = 0)
        {
            return View(UserService.GetUser(index));
        }

        [HttpGet]
        public IActionResult DeleteUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteUser(int index)
        {
            UserService.DeleteUser(index);
            return RedirectToAction("Index");
        }
    }
}
