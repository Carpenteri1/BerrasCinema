using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BerrasCinema.Models;

namespace BerrasCinema
{
    public class InMemoryMovieList
    {
        private const int MaxAmmountOfMovies = 18;
        private static int amountOfMovies;
        public static List<Movies> MovieList { get; set; }

        public static void InitializeAsync(CinemaDBContext context)
        {
            if (!context.Movie.Count().Equals(MaxAmmountOfMovies))
            {
                //database already have content just return
                var task = CraftDataAsync(context);//fix delegates make it run on another thread
                task.Wait(AddToDatabase(context));

                if (!context.Movie.Count().Equals(MaxAmmountOfMovies))
                {
                    InitializeAsync(context);
                } 
            }         
        }

        private static List<Movies> CreateMovieList(CinemaDBContext context)
        {
            MovieList = new List<Movies>
            {
            new Movies{MovieName = "Blade Runner"},
            new Movies{MovieName = "Showdown in Little Tokyo" },


            new Movies{MovieName = "Bad Boys II"},
            new Movies{MovieName = "The Delta Force" },


            new Movies{MovieName = "Rumble in the Bronx"},
            new Movies{MovieName = "Furious 7" },


            new Movies{MovieName = "You Only Live Twice"},
            new Movies{MovieName = "Hard to Kill" },


            new Movies{MovieName = "Escape from L.A"},
            new Movies{MovieName = "Demolition Man" },

            new Movies{MovieName = "Best of the Best"},
            new Movies{MovieName = "Invasion USA "},

            new Movies{MovieName = "Rambo"},
            new Movies{MovieName = "Showdown in Little Tokyo" },


            new Movies{MovieName = "Commando"},
            new Movies{MovieName = "Terminator "},

            new Movies{MovieName = "Karate Kid"},
            new Movies{MovieName = "Terminator" },
        };
            return MovieList;
        
    }

        private static int AddToDatabase(CinemaDBContext context) 
        {
            foreach(var s in MovieList) 
            {
                context.Movie.Add(s);
            }
            context.SaveChanges();

            return context.Movie.Count();
        }

        private async static Task CraftDataAsync(CinemaDBContext context) 
        {
            List<Movies> listOfMovies = await Task.Run(() => CreateMovieList(context));
        }
         
    }
}