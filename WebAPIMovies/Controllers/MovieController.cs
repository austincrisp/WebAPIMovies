using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIMovies.Models;
using System.Data.Entity;
using System.Web.Http.Description;

namespace WebAPIMovies.Controllers
{
    public class MovieController : ApiController
    {
        MovieReviewContext db = new MovieReviewContext();

        [ResponseType(typeof(Movie))]
        public IHttpActionResult Get()
        {
            DbSet<Movie> results = db.Movies;

            return Ok(results);
        }

        public IHttpActionResult Get(int id)
        {
            Movie result = db.Movies.Find(id);
            return Ok(result);
        }

        public IHttpActionResult Post(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();

            return Created("Get", movie);
        }

        public IHttpActionResult Put(int id, Movie movie)
        {
            movie.Id = id;
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
