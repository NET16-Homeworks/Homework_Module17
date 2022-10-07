using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.ComponentModel.DataAnnotations;
using Homework_Module17.Data;


namespace Homework_Module17.Models
{

    public class UserViewModel
    {
        public string Name { get; set; }   
        public Data.HelpData.Sex Sex = Data.HelpData.Sex.Man;
 
        public string Country { get; set; }

        public bool IsMarried { get; set; } = false;
    }
}
