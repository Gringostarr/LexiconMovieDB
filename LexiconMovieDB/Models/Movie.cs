using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LexiconMovieDB.Models
{
    public enum Genre
    {
        Thriller,
        Horror,
        Drama,
        Comedy,
        [Display(Name = "Drama Comedy")]
        DramaComedy,
        Action,
        SciFi,
        Western,
        Documentary
    }

    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Title { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "only positive values")]
        public int Length { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Age Limit")]
        [Range(0, 18, ErrorMessage = "0-18 please")]
        public int AgeLimit { get; set; }

        [Range(0, 100, ErrorMessage ="0-100 please")]
        public int MetaScore { get; set; }

        // Generates no column in DB table
        public string LengthInHours
        {
            get
            {
                var hours = Length / 60;
                var minutes = Length - 60 * hours;
                return $"{hours}h:{minutes:00}m";
            }
        }
    }
}