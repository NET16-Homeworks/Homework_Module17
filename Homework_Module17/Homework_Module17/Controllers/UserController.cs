using Microsoft.AspNetCore.Mvc;
using Homework_Module17.Services;
using Homework_Module17.Models;

namespace Homework_Module17.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var userService = new UserService();

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
            var userService = new UserService();
            userService.AddUser(user);

            return RedirectToAction("Index");
        }

        public IActionResult GetUser(int index)
        {
            return View(index);
        }


        [HttpGet]
        public IActionResult DeleteUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteUser(int userIndex)
        {
            var userService = new UserService();
            userService.DeleteUser(userIndex);

            return RedirectToAction("Index");
        }
    }
}
