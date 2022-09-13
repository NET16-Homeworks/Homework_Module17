using Homework_Module17.ViewModels;

namespace Homework_Module17.Services
{
    public class UserService
    {
        public static List<UserViewModel> _users = new List<UserViewModel>
        {
            new UserViewModel
            {
                Name = "Pasha",
                Sex = Enums.SexEnum.Man,
                Country = "Belarus",
                IsMarried = false
            },
            new UserViewModel
            {
                Name = "Alexandra",
                Sex = Enums.SexEnum.Woman,
                Country = "Ukrain",
                IsMarried = true
            },
            new UserViewModel
            {
                Name = "Amelia",
                Sex = Enums.SexEnum.Woman,
                Country = "Poland",
                IsMarried = false
            }
        };

        public List<UserViewModel> GetUsers()
        {
            return _users;
        }

        public UserViewModel GetUser(int index)
        {
            var user = _users[index];
            return user;
        }

        public void AddUser(UserViewModel user)
        {
            _users.Add(user);
        }

        public void DeleteUser(int index)
        {
            _users.RemoveAt(index);
        }


    }
}
