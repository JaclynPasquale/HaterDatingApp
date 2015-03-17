using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HaterDatingApp.Repository;
using HaterDatingApp.Model;
using HaterDatingApp.Controllers;

namespace HaterDatingApp.Controllers
{
    public class ProfileController : ApiController
    {

        //private iProfileRepository _repo;
        //public ProfileController(iProfileRepository repo)
        //{
        //    _repo = repo; 
        //}
        
        // GET: api/APIProfile
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/APIProfile/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/APIProfile
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/APIProfile/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/APIProfile/5
        public void Delete(int id)
        {
        }
    }
}
