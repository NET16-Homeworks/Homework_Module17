using Microsoft.AspNetCore.Mvc;
using Homework_Module17.Services;
using Homework_Module17.Models;


namespace Homework_Module17.Controllers
{
    public class UserController : Controller
    {
        private UserService userService = new UserService();
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

        [HttpGet]
        public IActionResult GetUser()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeleteUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteUser(int index)
        {
            userService.DeleteUser(index);
            return RedirectToAction("Index");
        }
    }
}
