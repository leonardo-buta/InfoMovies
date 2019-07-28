using System;
using System.Collections.Generic;

namespace InfoMovies.Domain.Models
{
    public class Movie : Entity
    {
        public string Title { get; set; }

        public string HomePage { get; set; }

        public string Tagline { get; set; }

        public int Runtime { get; set; }

        public DateTime ReleaseDate { get; set; }

        //public Rating Rating { get; set; }

        //public ICollection<Genre> Genres { get; set; }

        //public ICollection<Language> Languages { get; set; }
    }
}