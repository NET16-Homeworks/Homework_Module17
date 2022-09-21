using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.ComponentModel.DataAnnotations;
using Homework_Module17.Data;


namespace Homework_Module17.Models
{

    //public enum Sex
    //{
    //    [Display(Name = "Man")]
    //    Man,
    //    [Display(Name = "Woman")]
    //    Woman
    //}


    //public enum Country
    //{
    //    [Display(Name = "Belarus")]
    //    Belarus,
    //    [Display(Name = "Poland")]
    //    Poland,
    //    [Display(Name = "Ukraine")]
    //    Ukraine
    //}

    public class UserViewModel
    {
        public string Name { get; set; }   
        public Data.HelpData.Sex Sex = Data.HelpData.Sex.Man;
        //public Country Country = Country.Belarus; 
        public string Country { get; set; }

        public bool IsMarried { get; set; } = false;
    }
}
