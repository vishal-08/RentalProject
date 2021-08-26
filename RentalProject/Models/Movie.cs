using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentalProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Genre Genre{ get; set; }
        [Display (Name = "Genre")]
        public int GenreId { get; set; }
        [Display (Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }
        [Display (Name = "Stock Available")]
        public Byte NumberInStock { get; set; }
    }
}