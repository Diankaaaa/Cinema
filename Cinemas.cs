using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinemas
    {
        public string MovieTheatreName { get; set; }
        public DateTime Dt { get; set; }
        public string MovieTitle { get; set; }
        public string Genre { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Duration { get; set; }

        public string Ending { get; set; }

        public Cinemas(string movieTheatreName, DateTime dt, string movieTitle, string genre, int hours, int minutes, int duration, string ending)
        {
            MovieTheatreName = movieTheatreName;
            Dt = dt;
            MovieTitle = movieTitle;
            Genre = genre;
            Hours = hours;
            Minutes = minutes;
            Duration = duration;
            Ending = ending;
        }

        //public string Ending {get; set;}
        //public Cinemas(string ending)
        //{
        //    Ending = ending;
        //}
    }
}
