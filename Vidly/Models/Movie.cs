using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please select Movie's Name")]
        [StringLength(255)]
        public string Name { get; set; }
        
        public MovieGenre Genre { get; set; }

        [Required(ErrorMessage = "Please select Movie's Genre")]
        [Display(Name = "Movie's Genre")]
        public byte GenreId { get; set; }

        [Required(ErrorMessage = "Please select Movie's Release Date")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please add Movie's Stock Count")]
        [Range(1, 20, ErrorMessage = "Stock Count should be between 1 and 20")]
        [Display(Name = "Stock Count")]
        public int MovieStockCount { get; set; }

        public int AvailableCopies { get; set; }
    }
}