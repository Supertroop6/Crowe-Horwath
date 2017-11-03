using CroweHorwath;
using System.Collections.Generic;
using System.Web.Http;

namespace Web.Controllers
{
    public class WebServiceController : ApiController
    {
        // GET api/<controller>
        public string Get()
        {
            HelloWorld hello = new HelloWorld();
            return hello.SayGreeting();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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
    }
}