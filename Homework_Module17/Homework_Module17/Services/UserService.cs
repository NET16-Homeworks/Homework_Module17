using Homework_Module17.Models;
using Homework_Module17.Enums;
using Homework_Module17.Exceptions;

namespace Homework_Module17.Services
{
    public class UserService
    {
        public static List<UserViewModel> _users = new()
        {
            new UserViewModel() { Name = "Dmitriy", Country = "Belarus", IsMarried = true, Sex = SexOfUser.Male },
            new UserViewModel() { Name = "Dasha", Country = "Poland", IsMarried = false, Sex = SexOfUser.Female },
            new UserViewModel() { Name = "Vasiliy", Country = "Ukraine", IsMarried = true, Sex = SexOfUser.Male },
        };
        /*GetUsers() - возвращает всех юзеров
GetUser(index) - возвращает юзера по индексу
AddUser(user) - добавляет юзера в массив данных
DeleteUser(index) - удаляет юзера по индексу
*/
        public List<UserViewModel> GetUsers()
        {
            return _users;
        }

        public UserViewModel GetUser(int index)
        {
            var userNumberAtIndex = _users.ElementAt(index);
            if (userNumberAtIndex == null)
            {
                throw new UserNotFoundException("User doesn't Exist!");
            }

            return userNumberAtIndex;
        }

        public void AddUser(UserViewModel user)
        {
            _users.Add(user);
        }

        public void DeleteUser(int index)
        {
            var userNumberAtIndex = _users.ElementAt(index);
            if (userNumberAtIndex == null)
            {
                throw new UserNotFoundException("User Not Found!");
            }

            _users.RemoveAt(index);
        }
    }
    }

