using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace event_api.Controllers
{
    public class ConventionsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Gets()
        {
            string str = "get without id";
            return Ok(new { str });
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            string str = "single string";
            return Ok(new { id,str});
        }
        [HttpPost]
        public IHttpActionResult foo()
        {
            string s = "post string";
            return Ok(new { s });
        }
        [HttpDelete]
        public IHttpActionResult ab()
        {
            string str = "deleted";
            return Ok(new { str });
        }
        [HttpPut]
        public IHttpActionResult cde(int id)
        {
            string s = "string with " + id + " is updated";
            return Ok(new { s });
        }
    }
}
