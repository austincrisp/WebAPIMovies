using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPIMovies.Models;

namespace WebAPIMovies.Controllers
{
    public class UserController : ApiController
    {
        MovieReviewContext db = new MovieReviewContext();

        [ResponseType(typeof(User))]
        public IHttpActionResult Get()
        {
            DbSet<User> results = db.Users;

            return Ok(results);
        }

        public IHttpActionResult Get(int id)
        {
            User result = db.Users.Find(id);
            return Ok(result);
        }

        public IHttpActionResult Post(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();

            return Created("Get", user);
        }

        public IHttpActionResult Put(int id, User user)
        {
            user.Id = id;
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
