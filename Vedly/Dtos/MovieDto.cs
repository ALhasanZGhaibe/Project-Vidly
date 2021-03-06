using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vedly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stocks")]
        public int NumberInStocks { get; set; }

        public GenreDto Genre { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Genre")]
        public Byte GenreId { get; set; }
    }
}