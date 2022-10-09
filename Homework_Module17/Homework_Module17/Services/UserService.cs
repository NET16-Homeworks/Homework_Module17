using Homework_Module17.Models;
using Homework_Module17.Data;
namespace Homework_Module17.Services

{
    public class UserService
    {
        static UserService()
        {
            IniUsers();
        }

        public static List<UserViewModel> Users = new List<UserViewModel>();

        protected static void IniUsers()
        {
            var users = Users;
            users.Add(new UserViewModel() { Country = Data.HelpData.ListCountry[0], 
                                            Name = "Vladimir Solovey", Sex = Data.HelpData.Sex.Man, IsMarried = false });
            users.Add(new UserViewModel() { Country = Data.HelpData.ListCountry[1], 
                                            Name = "Sveta Sokolova", Sex = Data.HelpData.Sex.Woman, IsMarried = true });
            users.Add(new UserViewModel() { Country = Data.HelpData.ListCountry[2], 
                                            Name = "Ulia Ivanova", Sex = Data.HelpData.Sex.Woman, IsMarried = false });
            users.Add(new UserViewModel() { Country = Data.HelpData.ListCountry[1], 
                                            Name = "Ivan Brovkin", Sex = Data.HelpData.Sex.Man, IsMarried = true });
        }

        public UserViewModel GetUser(int index)
        {
            return Users[index];    
        }

        public List<UserViewModel> GetUsers()
        {
            return Users;
        }

        public void AddUser(UserViewModel user)
        {
            Users.Add(user);
        }

        public void DeleteUser(int index)
        {
            Users.RemoveAt(index);
        }

    }
}
