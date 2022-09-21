using Homework_Module17.Services;
using Homework_Module17.Models;
using Homework_Module17.Data;
using Microsoft.AspNetCore.Mvc;

namespace Homework_Module17.Components
{
    [ViewComponent]
    public class GetUserViewComponent
    {
        public string Invoke(UserViewModel userViewModel)
        {
            string sIsMarried = "Yes";
            if (!userViewModel.IsMarried) sIsMarried = "No";
            return $"Name: {userViewModel.Name}; Country: {userViewModel.Country}; Sex: {userViewModel.Sex}; IsMarried: {sIsMarried}";
        }
    }
}
