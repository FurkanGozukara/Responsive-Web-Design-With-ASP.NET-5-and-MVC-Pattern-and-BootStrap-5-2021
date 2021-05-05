using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Models
{
    [Serializable]
    public class Lecture10
    {
        [Display(Name = "New Title:")]
        public string srTitle { get; set; }
        public int irCounter { get; set; }

        [Phone]
        [Display(Name = "Enter your phone number:")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [Display(Name = "Enter your email:")]
        public string MailAddress { get; set; }

        [Display(Name = "Set your password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Set your birthday:")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; } = new DateTime(2000, 1, 1);

        [Display(Name = "Will you be online:")]
        public bool IsActive { get; set; }

        [Display(Name = "Type your comment as you wish:")]
        [DataType(DataType.MultilineText)]
        public string BigLetter { get; set; }
    }
}
