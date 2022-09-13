using Microsoft.AspNetCore.Mvc;
using Homework_Module17.Services;
using Homework_Module17.Models;
using Homework_Module17.Services;

namespace Homework_Module17.Controllers
{
    public class UserController : Controller
    {
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
                UserService.DeleteUser(userIndex);

                return RedirectToAction("Index");
            }
        }
}
