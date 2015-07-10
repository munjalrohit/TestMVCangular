using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWithAngularJs.Controllers
{
    public class TestrohitController : ApiController
    {
        // GET api/testrohit
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/testrohit/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/testrohit
        public void Post([FromBody]string value)
        {
        }

        // PUT api/testrohit/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/testrohit/5
        public void Delete(int id)
        {
        }
    }
}
