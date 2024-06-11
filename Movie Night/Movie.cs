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

        public bool Fresh () { 
            return reviewScore > 75; 
        }

        public Movie(string title, string rating, int score)
        {
            this.title = title;
            this.reviewScore = score;
            this.rating = rating;
        }

        public override string ToString (){

            var description = $"{title} \n Rated {rating} \n {reviewScore}% on RT ";

            var Freshinfo = Fresh() ? "-Certified Fresh" : "";
            
            description += Freshinfo;

            return description;
        }
    }
}