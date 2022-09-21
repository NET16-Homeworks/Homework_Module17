using Homework_Module17.Models;
using Homework_Module17.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Homework_Module17.Data;

namespace Homework_Module17.Controllers;

public class UserController : Controller
{
    private static UserService userService = new UserService();
    private static string sError = string.Empty;
    public IActionResult UserView()
    {
        return View(userService.GetUsers());
    }

    [HttpGet]
    public IActionResult AddUser()
    {
        ViewBag.lstCountry = Data.HelpData.ListCountry;
        return View();
    }

    //SelectList books = new SelectList(db.Books, "Author", "Name");
    //ViewBag.Books = books;

    [HttpPost]
    public IActionResult AddUser(UserViewModel userViewModel)
    {
        if (userViewModel == null)
        {
            sError = "Missing user data";
            return RedirectToAction("ErrorMessage");
        }
        else
        {
            try
            {
                if (
                    (String.IsNullOrEmpty(userViewModel.Name)) | (String.IsNullOrEmpty(userViewModel.Country)) |
                    (String.IsNullOrEmpty(Convert.ToString(userViewModel.Sex)))
                   )
                {
                    sError = "Incomplete user data provided";
                    throw new Exception(sError);
                }
                userService.AddUser(userViewModel);
            }
            catch
            {
                sError = "Incomplete user data provided";
                return RedirectToAction("ErrorMessage");
            }
        }
        //Response.Redirect("~/User/AddUser");
        return RedirectToAction("UserView");
        //return Content($"{userViewModel.Name} - {userViewModel.Country} - {userViewModel.Sex} - {userViewModel.IsMarried}");
    }

    public ActionResult _GoBack()
    {
        ViewBag.Message = "Это частичное представление.";
        return PartialView();
    }

    [HttpGet]
    public IActionResult GetUser()
    {
        UserViewModel userViewModel = new UserViewModel();  
        userViewModel = userService.GetUser(0);
        return View(userViewModel);
    }

    [HttpGet]
    public IActionResult DeleteUser()
    {
        return View();
    }
    [HttpPost]
    public IActionResult DeleteUser(string index)
    {
       try
        {
            int _index = Convert.ToInt32(index);
            try
            {
                userService.DeleteUser(_index);
                return RedirectToAction("UserView");
            }
            catch
            {
                sError = "Out of range";
                return RedirectToAction("ErrorMessage");
            }
        }
        catch
        {
            sError = "The entered value is not an integer";
            return RedirectToAction("ErrorMessage");
        }
        
    }

    [HttpGet]
    public IActionResult ErrorMessage()
    {
        ViewBag.sError = sError;
        return View();
    }
}
