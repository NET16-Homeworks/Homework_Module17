namespace Homework_Module17.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public UserSex Sex { get; set; }
        public string Country { get; set; }
        public bool IsMarried { get; set; }
    }

    public enum UserSex
    {
        Male, Female
    }
}
