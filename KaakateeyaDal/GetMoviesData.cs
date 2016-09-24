using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaakateeyaMl;
using KaakateeyaBal;

namespace KaakateeyaDal
{
    public class GetMoviesData
    {
        public void getMovieDetails()
        {
            MovieDisplay MVD = new Derived();
            int iCount = MVD.MovieDisplayList();
        }

    }
}
