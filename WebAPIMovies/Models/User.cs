using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIMovies.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public int ReviewId { get; set; }
    }
}