using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_1.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    public class webUser
    {
        public string FirstName { get; set; }
        public string LastName;
        public DateTime Birthday = DateTime.Now;
    }

}
