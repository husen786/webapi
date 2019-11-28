using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace event_api.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/values/GetNames")]
        [HttpGet]
        public List<string> GetNames()
        {
            List<string> str = new List<string>();
            str.Add("Rahat Husen");
            str.Add("Lionel Messi");
            str.Add("Nasir Husen");
            return str;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
