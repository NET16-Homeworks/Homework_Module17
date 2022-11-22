using Homework_Module17.Services;
using Microsoft.AspNetCore.Mvc;

namespace Homework_Module17.Components
{
    public class GetUserViewComponent : ViewComponent
    {
        private const int INDEX = 0;

        public IViewComponentResult Invoke()
        {

            var user = UserServices.GetUser(INDEX);
            return View(user);
        }
    }
}
