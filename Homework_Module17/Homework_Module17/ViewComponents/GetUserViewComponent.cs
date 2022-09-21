using Homework_Module17.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Homework_Module17.Services;

namespace Homework_Module17.ViewComponents
{
    public class GetUserViewComponent : ViewComponent
    {
        private readonly UserService _userService = new UserService();
        //v методе Invoke компонента получите из UserService
        //первого юзера и передайте его в вызов метода View.
        //На представлении выведите информацию о юзере в формате
        //{PropertyName}: {PropertyValue} …

        //[HttpGet]
        public IViewComponentResult Invoke()
        {
            return View(_userService.GetUser(0));
        }
    }
}
