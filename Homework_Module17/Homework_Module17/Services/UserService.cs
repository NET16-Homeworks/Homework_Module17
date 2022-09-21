using Microsoft.AspNetCore.Mvc;
using Homework_Module17.ViewModels;
using System.Collections.Generic;
using Homework_Module17.Enums;

namespace Homework_Module17.Services
{
    public class UserService
    {
        private static List<UserViewModel> _users  = new ()
        {
            new UserViewModel
            {
                Name = "Annet",
                sex = UserSex.Woman,
                Country = "Belarus",
                IsMarried = false
            },

            new UserViewModel
            {
                Name = "Hero",
                sex = UserSex.Man,
                Country = "Poland",
                IsMarried = true
            },

            new UserViewModel
            {
                Name = "Michael",
                sex = UserSex.Man,
                Country = "Poland",
                IsMarried = false
            },

            new UserViewModel
            {
                Name = "Vlada",
                sex = UserSex.Woman,
                Country = "Ukraine",
                IsMarried = true
            }
        };

        public  List<UserViewModel> GetUsers ()
        {
            return _users;
        }

        public UserViewModel GetUser(int index)
        {
            return _users[index];
        }

        public void AddUser (UserViewModel user)
        {
            _users.Add(user);
        }

        public void DeleteUser (int index)
        {
            _users.RemoveAt(index);
        }


    }
}
