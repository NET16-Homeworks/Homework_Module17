using Microsoft.AspNetCore.Mvc;
using Homework_Module17.Services;

namespace Homework_Module17.SeparateComponents
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
