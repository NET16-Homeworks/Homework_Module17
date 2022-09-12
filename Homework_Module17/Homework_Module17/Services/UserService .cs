using Homework_Module17.Models;

namespace Homework_Module17.Services
{
    public static class UserService
    {
        static List<UserViewModel> _users = new()
        {
            new UserViewModel() { Name = "User1", Country = "Беларусь", IsMarried = true, Sex = UserSex.Male },
            new UserViewModel() { Name = "User2", Country = "США", IsMarried = false, Sex = UserSex.Female },
            new UserViewModel() { Name = "User3", Country = "Украина", IsMarried = true, Sex = UserSex.Male },
            new UserViewModel() { Name = "User4", Country = "Бельгия", IsMarried = false, Sex = UserSex.Female },
            new UserViewModel() { Name = "User5", Country = "Норвегия", IsMarried = true, Sex = UserSex.Male },
        };

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
