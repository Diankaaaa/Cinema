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
        public string Datet { get; set; }
        public double Duration { get; set; }

        public string Ending { get; set; }

        public Cinemas(string movieTheatreName, DateTime dt, string movieTitle, string genre, string datet, double duration, string ending)
        {
            MovieTheatreName = movieTheatreName;
            Dt = dt;
            MovieTitle = movieTitle;
            Genre = genre;
            Datet = datet;
            Duration = duration;
            Ending = ending;
        }
    }
}
