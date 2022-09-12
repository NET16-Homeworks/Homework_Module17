using Homework_Module17.Services;
using Homework_Module17.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework_Module17.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(UserService.listOfUsers);
        }
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(UserViewModel user)
        {
            UserService.listOfUsers.Add(user);
            return RedirectToAction("Index");
        }
        public IActionResult GetUser()
        {
            return View();
        }
        public IActionResult DeleteUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteUser(int index)
        {
            UserService.listOfUsers.Remove(UserService.listOfUsers[index]);
            return RedirectToAction("Index");
        }
    }
}
