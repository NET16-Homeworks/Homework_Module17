using Homework_Module17.Models;

namespace Homework_Module17.Services
{
    public static class UserService
    {
        private static readonly List<UserViewModel> _users = new List<UserViewModel>();

        public static List<UserViewModel> GetUsers()
        {
            return _users;
        }

        public static UserViewModel GetUser(int index)
        {
            return _users[index];
        }

        public static void AddUser(UserViewModel user)
        {
            _users.Add(user);
        }

        public static void DeleteUser(int index)
        {
            _users.RemoveAt(index);
        }
    }
}
