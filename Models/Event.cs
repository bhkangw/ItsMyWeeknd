using System;
using System.ComponentModel.DataAnnotations;

namespace ItsMyWeeknd.Models
{
    public class Event
    {
        [Required]
        public object Destination { get; set; }

    //     [Display(Name = "Date")]
    //     [MyDate(ErrorMessage = "Date must be in the future")]
    //     public DateTime FromDate { get; set; }

    //     [Display(Name = "To")]
    //     [MyDate(ErrorMessage = "Date must be in the future")]
    //     public DateTime ToDate { get; set; }
    // }

    // public class MyDateAttribute : ValidationAttribute
    // {
    //     public override bool IsValid(object value)
    //     {
    //         DateTime d = Convert.ToDateTime(value);
    //         return d >= DateTime.Now;
    //     }
    }
}