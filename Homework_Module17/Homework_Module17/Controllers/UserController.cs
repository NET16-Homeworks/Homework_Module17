using Homework_Module17.Models;
using Homework_Module17.Services;
using Homework_Module17.UserHelper;
using Microsoft.AspNetCore.Mvc;

namespace Homework_Module17.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(UserServices.users);
        }

        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(string name, int sex, string country, bool actionIsMarried)
        {
            UserViewModel newUser = new UserViewModel()
            { Name = name, Sex = (SexEnum)sex, Country = country, isMarried = actionIsMarried };
            UserServices.AddUser(newUser);
            return RedirectToAction("Index");
        }

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
            UserServices.DeleteUser(index);
            return RedirectToAction("Index");
        }
    }
}
