using Homework_Module17.ViewModels;
using Homework_Module17.Services;
using Microsoft.AspNetCore.Mvc;


namespace Homework_Module17.Components

{
    public class GetUser : ViewComponent
    {
        private UserService userService = new UserService();

        public IViewComponentResult Invoke(int id = 0)
        {
            UserViewModel user = userService.GetUser(id);         
            return View(user);
        }
    }
}
