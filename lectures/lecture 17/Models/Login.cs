using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Models
{
    public class Login
    {
        [Display(Name = "First Name:")]
        public string srFirstName { get; set; }
        [Display(Name = "Email:")]
        public string srEmail { get; set; }

        public TblUsers userValues { get; set; }

    }
}
