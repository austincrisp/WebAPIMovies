﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string IMDBLink { get; set; }
        public string ReleaseDate { get; set; }
    }
}