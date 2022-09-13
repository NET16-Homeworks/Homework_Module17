using Homework_Module17.Models;

namespace Homework_Module17.Services
{
    public class UserService
    {
        static List<UserViewModel> _users = new()
        {
            new UserViewModel() { Name = "Dmitriy", Country = "Belarus", IsMarried = true, Sex = UserSex.Male },
            new UserViewModel() { Name = "Dasha", Country = "Poland", IsMarried = false, Sex = UserSex.Female },
            new UserViewModel() { Name = "Vasiliy", Country = "Ukraine", IsMarried = true, Sex = UserSex.Male },
        };
        /*GetUsers() - возвращает всех юзеров
GetUser(index) - возвращает юзера по индексу
AddUser(user) - добавляет юзера в массив данных
DeleteUser(index) - удаляет юзера по индексу
*/
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
