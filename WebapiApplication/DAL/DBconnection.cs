using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebapiApplication.ML;

namespace WebapiApplication.DAL
{
    public class DBconnection
    {
        List<ActivePatientReport> movies = new List<ActivePatientReport>
         {
         new ActivePatientReport{ ID = 1, Title = "Taken", Genre = "Action", ReleaseDate = new DateTime(2008,9,26)},
         new ActivePatientReport{ ID = 2, Title = "Django Unchained", Genre = "Western", ReleaseDate = new DateTime(2013,1,18)},
         new ActivePatientReport{ ID = 3, Title = "Cars", Genre = "Animation", ReleaseDate = new DateTime(2006,7,28)},
         new ActivePatientReport{ ID = 4, Title = "The Hangover", Genre = "Comedy", ReleaseDate = new DateTime(2009,6,12)},
         new ActivePatientReport{ ID = 5, Title = "The Woman in Black", Genre = "Horror", ReleaseDate = new DateTime(2012,2,10)},
         new ActivePatientReport{ ID = 6, Title = "SSSSSSSSSSSS", Genre = "Horror", ReleaseDate = new DateTime(2012,2,10)},
         new ActivePatientReport{ ID = 7, Title = "VVVVVVVVVV", Genre = "Horror", ReleaseDate = new DateTime(2012,2,10)},
         new ActivePatientReport{ ID = 8, Title = "NNNNNNNNNNNN", Genre = "Horror", ReleaseDate = new DateTime(2012,2,10)},
         new ActivePatientReport{ ID = 9, Title = "YYYYYYYYYYYY", Genre = "Horror", ReleaseDate = new DateTime(2012,2,10)},
         new ActivePatientReport{ ID = 10, Title = "JJJJJJJJJJJ", Genre = "Horror", ReleaseDate = new DateTime(2012,2,10)}
        };

        public List<ActivePatientReport> getDALDetails()
        {
            return movies;
        }
    }

}