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
            userService.DeleteUser(userIndex);

            return RedirectToAction("Index");
        }
    }
}
