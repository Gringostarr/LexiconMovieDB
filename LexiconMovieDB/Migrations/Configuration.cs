namespace LexiconMovieDB.Migrations
{
    using System;
    using System.Data.Entity;
    using LexiconMovieDB.DAL;
    using LexiconMovieDB.Models;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Movies.AddOrUpdate(
                m => m.Title,
                new Movie {
                    Title = "Return of the killer Tomatoes",
                    Genre = Genre.Horror,
                    AgeLimit = 15,
                    Length = 90,
                    MetaScore = 7
                },
                new Movie
                {
                    Title = "The God Father",
                    Genre = Genre.Thriller,
                    AgeLimit = 15,
                    Length = 90,
                    MetaScore = 100
                },
                  new Movie
                  {
                      Title = "Alien",
                      Genre = Genre.Horror,
                      AgeLimit = 15,
                      Length = 153,
                      MetaScore = 95
                  },
                new Movie
                {
                    Title = "The return of the zombie programmers",
                    Genre = Genre.Horror,
                    AgeLimit = 15,
                    Length = 144,
                    MetaScore = 25
                },

                 new Movie
                 {
                     Title = "Death Race 2000",
                     Genre = Genre.Drama,
                     AgeLimit = 15,
                     Length = 155,
                     MetaScore = 90
                 },
                 new Movie
                 {
                     Title = "Det våras för Hitler",
                     Genre = Genre.Comedy,
                     AgeLimit = 7,
                     Length = 170,
                     MetaScore = 88
                 }






                );
        }
    }
}
