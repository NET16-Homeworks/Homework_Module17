using Homework_Module17.SeparateElements;

namespace Homework_Module17.Models
{
    public class UserViewModel
    {
        public string Name { get; set; } = string.Empty;
        public SexEnum Sex { get; set; }
        public string Country { get; set; } = string.Empty;
        public bool IsMarried { get; set; }
    }
}
