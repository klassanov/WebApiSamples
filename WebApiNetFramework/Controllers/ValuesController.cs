using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using WebApiNetFramework.Models;

namespace WebApiNetFramework.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [ActionName("Home")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            HttpResponseMessage response = Request.CreateResponse(new Person { Name = "Alex" });
            return response;
            //return Ok(new Person { Name = "Karolina" });
        }

        public Person Get(string name)
        {
            return new Person { Name = "Karolina" };
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}
