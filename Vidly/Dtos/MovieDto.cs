using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please select Movie's Name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select Movie's Genre")]
        public byte GenreId { get; set; }

        [Required(ErrorMessage = "Please select Movie's Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please add Movie's Stock Count")]
        [Range(1, 20, ErrorMessage = "Stock Count should be between 1 and 20")]
        public int MovieStockCount { get; set; }
    }
}