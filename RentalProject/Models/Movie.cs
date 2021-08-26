using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentalProject.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }

        public Genre Genre{ get; set; }
        [Display (Name = "Genre")]
        [Required]
        public int GenreId { get; set; }
        [Display (Name ="Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }
        [Required]
        [Display (Name = "Stock Available")]
        public Byte NumberInStock { get; set; }
    }
}