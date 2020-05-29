using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BerrasCinema.Models;

namespace BerrasCinema
{
    public class InMemoryMovieList
    {
        private const int MaxAmmountOfMovies = 18;

        public static void Initialize(CinemaDBContext context)
        {
            if (!context.Movie.Count().Equals(MaxAmmountOfMovies))
                {
                //database already have content just return
                    List<Movies> listOfMovies = CreateMovieList();

                    if (!AddToDatabase(context,listOfMovies).Count().Equals(MaxAmmountOfMovies))
                    {
                        Initialize(context);
                    }
                }
              
        }

        public static List<Movies> CreateMovieList()
        {
           List<Movies> createdList = new List<Movies>
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
            return createdList;
        
    }

        private static List<Movies> AddToDatabase(CinemaDBContext context,List<Movies>listOfMovies) 
        {
            foreach(var s in listOfMovies) 
            {
                context.Movie.Add(s);
            }
            context.SaveChanges();

            return listOfMovies;
        }
    }
}