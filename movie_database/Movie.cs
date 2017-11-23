using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_database
{
    class Movie
    {
        private string moviename { set; get; }
        private int length { set; get; }
        private int rating { set; get; }
        private int budget { set; get; }
        private int producer { set; get; }
        private int genre { set; get; }
        private int movieid { set; get; }



        public string MovieName
        {
            get { return moviename; }
            set { moviename = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public int Producer
        {
            get { return producer; }
            set { producer = value; }
        }

        public int Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Movieid
        {
            get { return movieid; }
            set { movieid = value; }
        }
    }
}
