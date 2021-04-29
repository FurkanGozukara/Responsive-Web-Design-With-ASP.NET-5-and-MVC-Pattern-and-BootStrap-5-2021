using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using lecture_9;

namespace lecture_9_cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            lecture_9.Models.Lecture9 lec9Model = new lecture_9.Models.Lecture9();
            lec9Model.dtBirthDay = new DateTime(1949, 3, 3);
            lec9Model.irUserId = 2;
            lec9Model.srEmail = "da@gmail.com";
            lec9Model.srEmailRepeated = "a@gmail.com";
            lec9Model.srFirstName = "ads";
            lec9Model.srLastName = "12312312312312312312312312312312321";

            var context = new ValidationContext(lec9Model, null, null);
            var results = new List<ValidationResult>();

            //this first checks regular requirements and if all passes, it then checks IValidatableObject
            //if any of the regular checks fails, it shortcut and do not check custom IValidatableObject
            var isValid = Validator.TryValidateObject(lec9Model, context, results, true);
        

            if (!isValid)
            {
                Console.WriteLine("User is NOT valid! Errors:");
                foreach (var validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
            }
            Console.WriteLine("Done...");
            Console.ReadKey();
        }
    }
}
