using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LexiconMovieDB.Models;

namespace LexiconMovieDB.DAL
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("LMDB")
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}