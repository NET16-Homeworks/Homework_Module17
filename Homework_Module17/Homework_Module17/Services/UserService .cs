using Homework_Module17.Models;
using Homework_Module17.Enums;
using Homework_Module17.Exceptions;

namespace Homework_Module17.Services
{
    public class UserService
    {
        public static List<UserViewModel> _users = new()
        {
            new UserViewModel() { Name = "User1", Country = "Беларусь", IsMarried = true, Sex = UserSex.Male },
            new UserViewModel() { Name = "User2", Country = "США", IsMarried = false, Sex = UserSex.Female },
            new UserViewModel() { Name = "User3", Country = "Украина", IsMarried = true, Sex = UserSex.Male },
            new UserViewModel() { Name = "User4", Country = "Бельгия", IsMarried = false, Sex = UserSex.Female },
            new UserViewModel() { Name = "User5", Country = "Норвегия", IsMarried = true, Sex = UserSex.Male },
        };

        public List<UserViewModel> GetUsers()
        {
            return _users;
        }

        public UserViewModel GetUser(int index)
        {
            var userByIndex = _users.ElementAt(index);
            if (userByIndex == null)
            {
                throw new UserNotFoundException("User Not Found!");
            }

            return userByIndex;
        }

        public void AddUser(UserViewModel user)
        {
            _users.Add(user);
        }

        public void DeleteUser(int index)
        {
            var userByIndex = _users.ElementAt(index);
            if (userByIndex == null)
            {
                throw new UserNotFoundException("User Not Found!");
            }

            _users.RemoveAt(index);
        }
    }
}
