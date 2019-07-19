using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var db = new MovieDBContext())
            {
                Movie movie = new Movie { Rank = 1, Title = "The Shawshank Redemption", Year = 1994 };
                db.Movies.Add(movie);
                db.SaveChanges();
            }
        }
    }
}
