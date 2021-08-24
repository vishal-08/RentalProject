﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Genre Genre{ get; set; }
        public int GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }
        public Byte NumberInStock { get; set; }
    }
}