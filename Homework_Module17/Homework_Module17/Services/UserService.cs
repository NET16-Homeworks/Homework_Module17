using Homework_Module17.ViewModels;

namespace Homework_Module17.Services
{
    public class UserService
    {
        public static List<UserViewModel> listOfUsers = new List<UserViewModel>()
        {
            new UserViewModel{Name = "Valera", Sex = Sex.Man, Country = "Poland", IsMarried = true},
            new UserViewModel{Name = "Ira", Sex = Sex.Woman, Country = "Belarus", IsMarried = false},
            new UserViewModel{Name = "Vlad", Sex = Sex.Man, Country = "Spain", IsMarried = false},
            new UserViewModel{Name = "Dasha", Sex = Sex.Woman, Country = "Lithuania", IsMarried = true}
        };
        public static List<UserViewModel> GetUsers()
        {
            return listOfUsers;
        }
        public static UserViewModel GetUser(int index)
        {
            return listOfUsers[index];
        }
        public static void AddUser(UserViewModel user)
        {
            if(listOfUsers.Contains(user))
            {
                throw new Exception("This user is already added");
            }
            listOfUsers.Add(user);
        }
        public static void DeleteUser(int index)
        {
            listOfUsers.Remove(listOfUsers[index]);
        }
    }
}
