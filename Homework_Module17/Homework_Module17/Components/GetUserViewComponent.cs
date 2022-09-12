using Homework_Module17.Services;
using Homework_Module17.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework_Module17.Components
{
    public class GetUserViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("GetUser", UserService.listOfUsers[0]);
        }
    }
}
