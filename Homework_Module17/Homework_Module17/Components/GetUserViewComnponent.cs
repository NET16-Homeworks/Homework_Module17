using Homework_Module17.ViewModels;
using Homework_Module17.Services;
using Microsoft.AspNetCore.Mvc;


namespace Homework_Module17.Components

{
    public class GetUser : ViewComponent
    {
        UserService userService = new UserService();

        

        public string Invoke(int id = 0)
        {
            UserViewModel user = userService.GetUser(id); ;           
            return $"Name: {user.Name}, Country: {user.Country}, Sex: {user.Sex}, Is Married: {user.IsMarried}";
        }
    }
}
