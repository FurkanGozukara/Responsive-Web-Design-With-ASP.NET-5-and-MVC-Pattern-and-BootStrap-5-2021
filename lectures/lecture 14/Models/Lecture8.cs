using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Models
{
    public class Lecture8
    {
        //all of the possible property attributes data annotations
        //https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute?view=net-5.0
        [Display(Name = "First Name:", Description = "Please enter your first name to the text box.", Prompt = "This is the prompt message")]
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string srFirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(AllowEmptyStrings = true )]
        public string srLastName { get; set; }

        public string srPostMessage { get; set; }

        [Display(Name = "Email:", Description = "please enter a valid email")]
        [Required(ErrorMessage = "You have to enter a valid email. Email cant be left empty.")]
        [EmailAddress]
        [Compare("srEmailRepeated")]
        public string srEmail { get; set; }

        public string srEmailRepeated { get; set; }

        [Display(Name = "User Id:", Description = "please enter a valid user id")]
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "the entered value was not a valid integer")]
        public int irUserId { get; set; }

     
        [myCustomBirthDayValidation]
        public DateTime dtBirthDay { get; set; }
    }

    public class myCustomBirthDayValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime birthday = (DateTime)value;
            if (birthday.Year < 1900)
                return new ValidationResult("Surely you are not THAT old?");
            if (birthday.Year > 2000)
                return new ValidationResult("Sorry, you're too young for this website!");
            if (birthday.Month == 12)
                return new ValidationResult("Sorry, we don't accept anyone born in December!");
            return ValidationResult.Success;
        }
    }
}
