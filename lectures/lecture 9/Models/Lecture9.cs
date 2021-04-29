using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Models
{
    public class Lecture9 : IValidatableObject
    {
        //all of the possible property attributes data annotations
        //https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute?view=net-5.0
        [Display(Name = "First Name:", Description = "Please enter your first name to the text box.", Prompt = "This is the prompt message")]
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string srFirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(AllowEmptyStrings = true)]
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

        public DateTime dtBirthDay { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.dtBirthDay.Year < 1950)
                yield return new ValidationResult("Surely you are not THAT old?", new[] { "dtBirthDay" });
            if (this.dtBirthDay.Year > 2010)
                yield return new ValidationResult("Sorry, you're too young for this website!", new[] { "dtBirthDay" });
            if (this.dtBirthDay.Month == 12)
                yield return new ValidationResult("Sorry, we don't accept anyone born in December!", new[] { "dtBirthDay" });
            if (!this.srEmail.StartsWith("a"))
                yield return new ValidationResult("Sorry, your email has to start with letter a", new[] { "srEmail" });
        }
    }
}
