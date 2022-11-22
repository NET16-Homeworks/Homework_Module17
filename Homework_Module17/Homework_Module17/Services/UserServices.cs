using Homework_Module17.Models;
using Homework_Module17.UserHelper;
using System;

namespace Homework_Module17.Services
{
    public static class UserServices
    {
        public static List<UserViewModel> users = new List<UserViewModel>()
        {
            new UserViewModel() { Name = "Pavel", Country = "Belarus", isMarried = false, Sex = SexEnum.Man },
            new UserViewModel() { Name = "Kate", Country = "Ukraine", isMarried = false, Sex = SexEnum.Woman },
            new UserViewModel() { Name = "Kostya", Country = "Poland", isMarried = false, Sex = SexEnum.Man },
        };

        public static List<UserViewModel> GetUsers()
        {
            return users;
        }

        public static UserViewModel GetUser(int index)
        {
            return users[index];
        }

        public static void AddUser(UserViewModel user)
        {
            users.Add(user);
        }

        public static void DeleteUser(int index)
        {
            users.Remove(users[index]);
        }
    }
}
