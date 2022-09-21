using Microsoft.AspNetCore.Mvc;
using Homework_Module17.ViewModels;
using Homework_Module17.Services;

namespace Homework_Module17.Controllers
{
    public class UserController : Controller
    {
        //без след поля не сможем использовать методы юзерсервиса:
        private readonly UserService _userService = new UserService();
        private int index;

        [HttpGet]
        public IActionResult Index()
        {
            return View(_userService.GetUsers());
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return View(_userService.GetUsers());
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

          [HttpPost]
        public IActionResult AddUser(UserViewModel viewModel)
        {
            _userService.AddUser(viewModel);
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
            _userService.DeleteUser(index);
            return RedirectToAction("Index");
        }
    }
}
