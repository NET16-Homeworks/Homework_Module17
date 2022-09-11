using Microsoft.AspNetCore.Mvc;
using Homework_Module17.ViewModels;

namespace Homework_Module17.Services
{
    public class UserService 
    {
        private static List<UserViewModel> Users = new List<UserViewModel>();

        public List<UserViewModel> GetUsers()
        {
            return Users;
        }

        public UserViewModel GetUser(int index = 0)
        {       
                if (index >= Users.Count)
                {
                    index = 0;
                }
            return Users[index];
        }

        public void AddUser(UserViewModel user)
        {
            Users.Add(user);
        }

        public void DeleteUser(int index)
        {
            try
            {
                Users.RemoveAt(index);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }         
        }





        





    }
}
