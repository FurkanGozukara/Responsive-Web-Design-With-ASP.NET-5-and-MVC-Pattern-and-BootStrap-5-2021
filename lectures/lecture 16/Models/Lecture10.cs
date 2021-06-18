using Microsoft.AspNetCore.Mvc.Rendering;
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

        [MaxLength(32)]
        [MinLength(5)]
        public string srDescription { get; set; }

        public string srCountry { get; set; }

        public List<string> lstCountry { get; set; } = new List<string> { "Turkey", "Syria", "United States", "Germany" };

        public class csCountries
        {
            public string srCountryName { get; set; }
         
            public string srCountryCodes { get; set; }
        }

        public static List<csCountries> listOfCountryClass { get; set; } = new List<csCountries>
        {
            new csCountries{ srCountryName="Turkey",  srCountryCodes="TR"},
               new csCountries{ srCountryName="United States",  srCountryCodes="US"},
                  new csCountries{ srCountryName="Germany",  srCountryCodes="DE"}
        };

        [myCustomCountryCodeValidation]
        public string srSelectedCountryCode { get; set; }

        public WebUserValidationStatus validationStatus { get; set; }

        public enum WebUserValidationStatus
        {
            Unknown = -1,
            [Display(Name = "Not verified yet")]
            NotVerifiedYet = 0,
            [Display(Name = "Verified by e-mail")]
            VerifiedByMail = 1,
            [Display(Name = "Verified by phone")]
            VerifiedByPhone = 2
        }

        public string SelectedMovieId { get; set; }

        public List<string> listSelectedMovieIds { get; set; }

        public List<SelectListItem> MoviesList;

        public Lecture10()
        {
            SelectListGroup dramaGroup = new SelectListGroup
            {
                Name = "Drama Movies"
            };

            SelectListGroup actionGroup = new SelectListGroup
            {
                Name = "Action Moviews"
            };

            this.MoviesList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Group = dramaGroup,
                     Text= "Forrest Gump",
                     Value = "1"
                },
                new SelectListItem
                {
                       Group = dramaGroup,
                     Text= "Fight Club",
                     Value = "2"
                },
                    new SelectListItem
                {
                       Group = actionGroup,
                     Text= "Matrix",
                     Value = "3"
                },      new SelectListItem
                {
                       Group = actionGroup,
                     Text= "Mortal Kombat",
                     Value = "4"
                }
            };
        }
    }

    public class myCustomCountryCodeValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!Lecture10.listOfCountryClass.Select(pr => pr.srCountryCodes).ToList().Contains(value.ToString()))
            {
                return new ValidationResult("Are you trying to hack our website?");
            }
            return ValidationResult.Success;
        }
    }


}
