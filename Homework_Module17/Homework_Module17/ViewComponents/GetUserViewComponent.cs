using Microsoft.AspNetCore.Mvc;
using Homework_Module17.Services;

namespace Homework_Module17.ViewComponents
{
    public class GetUserViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("GetUser", UserService.GetUser(0));
        }
    }
}
