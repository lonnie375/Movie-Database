using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDataBase
{
    public class Movie
    {
        //Fields 
        public string Title { get; set; }
        public string Category { get; set; }

        //Constructor

        public Movie(string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;
        }

        public Movie()
        {
        }
        /*
        public string MovieCategory(string category)
        {

        }
        */

    }
}
