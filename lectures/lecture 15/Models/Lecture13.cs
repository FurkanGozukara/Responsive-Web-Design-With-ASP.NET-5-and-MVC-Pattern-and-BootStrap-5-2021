using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Models
{
    public class Lecture13
    {
        [Display(Name = "Car Id:")]
        public int CarId;
        [Display(Name = "Car Name:")]
        public string CarName { get; set; }

        public string HttpContext_Request_Query { get; set; }
        public string HttpContext_Request_QueryString { get; set; }

        public string FormProperties { get; set; }
        [Display(Name = "First Time Visiting Date:")]
        public DateTime firstTimeVisitDate { get; set; }
        public string cookieRemainingTime { get; set; }
    }
}
