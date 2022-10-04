using Homework_Module17.Models;
namespace Homework_Module17.Services
{
    public class UserService
    {
        public static List<UserViewModel> _users = new List<UserViewModel>
        {
            new UserViewModel
            {
                Name = "Pasha",
                Sex = Enums.EnumSex.Man,
                Country = "Беларусь",
                IsMarried = true
            },
            new UserViewModel
            {
                Name = "Masha",
                Sex = Enums.EnumSex.Women,
                Country = "Польша",
                IsMarried = false
            },
            new UserViewModel
            {
                Name = "Dasha",
                Sex = Enums.EnumSex.Women,
                Country = "Украина",
                IsMarried = true
            }
        };
        public List<UserViewModel> GetUsers()
        {
            return _users;
        }

        public UserViewModel GetUser(int index)
        {
            if ((index >= 0) && (index < _users.Count))
            {
                return _users[index];
            }
            else
            {
                throw new ArgumentException("Error! I can't find your user.");
            }        

        }
        public void AddUser(UserViewModel user)
        {
            _users.Add(user);
        }

        public void DeleteUser(int index)
        {
            if ((index >= 0) && (index < _users.Count))
            {
                _users.RemoveAt(index);
            }
            else
            {
                throw new ArgumentException("Error! I can't find your user.");
            }


            
        }


    }
}
