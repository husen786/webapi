using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace event_api.Controllers
{
    [RoutePrefix("api/custom")]
    public class Test1Controller : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Gets()
        {
            string str1 = "first string";
            string str2 = "second string";
            return Ok(new { str1, str2 });
        }
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            string str1 = "string by id";
            return Ok(new { id, str1});
        }

        [HttpPost]
        public IHttpActionResult PostString()
        {
            string str = "this is post method";
            return Ok(str);
        }
        [HttpDelete]
        [Route("foo/{id}")]
        public IHttpActionResult foo(int id)
        {
            string str = "string with id " + id + " is deleted";
            return Ok(str);
        }
        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult PutString(int id)
        {
            string str = "string with id " + id + " is updated";
            return Ok(str);
        }

    }
}
