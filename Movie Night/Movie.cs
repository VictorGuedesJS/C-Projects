using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Night
{
    public class Movie
    {
        public string title;
        public string rating;
        public int reviewScore;

        public Movie(string title, string rating, int score)
        {
            this.title = title;
            this.reviewScore = score;
            this.rating = rating;
        }
    }
}