using Homework_Module17.Services;
using Homework_Module17.UserHelper;

namespace Homework_Module17.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public SexEnum Sex { get; set; }
        public bool isMarried { get; set; }
    }
}
