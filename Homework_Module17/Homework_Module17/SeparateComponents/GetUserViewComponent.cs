using Homework_Module17.Services;
using Microsoft.AspNetCore.Mvc;

namespace Homework_Module17.ViewComponents
{
    public class GetUserViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var userService = new UserService();
            return View("GetUser", userService.GetUser(0));
        }
    }
}
