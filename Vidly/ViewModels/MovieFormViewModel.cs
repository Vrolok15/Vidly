using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<MovieGenre> MovieGenres { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Please select Movie's Name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select Movie's Genre")]
        [Display(Name = "Movie's Genre")]
        public byte? GenreId { get; set; }

        [Required(ErrorMessage = "Please select Movie's Release Date")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please add Movie's Stock Count")]
        [Range(1, 20, ErrorMessage = "Stock Count should be between 1 and 20")]
        [Display(Name = "Stock Count")]
        public int? MovieStockCount { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                {
                    return "Edit Movie";
                }

                return "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            MovieStockCount = movie.MovieStockCount;
            GenreId = movie.GenreId;
        }
    }
}
