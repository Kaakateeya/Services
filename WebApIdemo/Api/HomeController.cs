using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApIdemo.Api
{
    public class HomeController : ApiController
    {

        List<Movie> movies = new List<Movie> {
        new Movie{ ID = 1, Title = "Taken", Genre = "Action", ReleaseDate = new DateTime(2008,9,26)},
        new Movie{ ID = 2, Title = "Django Unchained", Genre = "Western", ReleaseDate = new DateTime(2013,1,18)},
        new Movie{ ID = 3, Title = "Cars", Genre = "Animation", ReleaseDate = new DateTime(2006,7,28)},
        new Movie{ ID = 4, Title = "The Hangover", Genre = "Comedy", ReleaseDate = new DateTime(2009,6,12)},
        new Movie{ ID = 5, Title = "The Woman in Black", Genre = "Horror", ReleaseDate = new DateTime(2012,2,10)}
    };

       

        // GET api/<controller>/5
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {

        }

        public int Getdisplay(int id1, int id2)
        {
            return id1 + id2;
        }


    }
}