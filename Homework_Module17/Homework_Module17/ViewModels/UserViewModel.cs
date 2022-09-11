using System.ComponentModel.DataAnnotations;

namespace Homework_Module17.ViewModels
{
    public record class UserViewModel
    {
        public string Name { get; set; }
        public sex Sex { get; set; }
        public string Country { get; set; }
        public bool IsMarried { get; set; }



        
    }

    public enum sex
    {
        [Display(Name = "Male")]
        male,
        [Display(Name = "Female")]
        female
    }
    
    
}
