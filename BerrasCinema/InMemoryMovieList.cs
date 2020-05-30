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
        private const int MaxAmmountOfMovies = 12;

        public static List<Movies> Initialize(CinemaDBContext context)
        {
            List<Movies> listOfMovies = new List<Movies>();
            if (!context.Movie.Count().Equals(MaxAmmountOfMovies))
            {
                listOfMovies = CreateMovieList();
                listOfMovies = AddMovieDuration(listOfMovies);
                listOfMovies = AddQueueTimes(listOfMovies);

                if (!AddToDatabase(context, listOfMovies).Count().Equals(MaxAmmountOfMovies))
                {
                    Initialize(context);
                }
                else//database already have content just return
                {
                    return listOfMovies;
                }
            }//database already have content just return
                return listOfMovies;   
        }


        private static List<Movies> AddQueueTimes(List<Movies> listOfMovies) 
        {
            double queuTime = 30;
            double durationToMinutes;
            foreach(var s in listOfMovies)
            {
                s.MovieStart = DateTime.Now.AddMinutes(queuTime);
                durationToMinutes = s.MovieDuration.Minute;
                queuTime += durationToMinutes;
                queuTime += 30;
                
            }

            return listOfMovies;
        }

        private static List<Movies> AddMovieDuration(List<Movies> listOfMovies)
        {
            DateTime myDate = new DateTime();
            double[] durations = new double[]{140,79,108,130,99,125,117,100,101,97,93,127};
            int i = 0;
            foreach (var s in listOfMovies)
            {
                s.MovieDuration = myDate.AddMinutes(durations[i]);
                i++;
            }

            return listOfMovies;
        }

        private static List<Movies> CreateMovieList()
        {
            List<Movies> createdList = new List<Movies>
            {
            new Movies{MovieName = "Invasion USA",},
            new Movies{MovieName = "Showdown in Little Tokyo", },
            

            new Movies{MovieName = "Terminator"},
            new Movies{MovieName = "The Delta Force" },


            new Movies{MovieName = "Rambo"},
            new Movies{MovieName = "Demolition Man" },


            new Movies{MovieName = "You Only Live Twice"},
            new Movies{MovieName = "Hard to Kill" },


            new Movies{MovieName = "Escape from L.A"},
            new Movies{MovieName = "Best of the Best" },

            new Movies{MovieName = "Commando"},
            new Movies{MovieName = "Karate Kid"},
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