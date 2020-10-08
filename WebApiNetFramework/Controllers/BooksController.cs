using System.Collections.Generic;
using System.Web.Http;

namespace WebApiNetFramework.Controllers
{
    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        [Route("")]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "book1", "book2" };
        }

        [Route("{bookId:int}")]
        public string Get(int bookId)
        {
            return $"book{bookId}";
        }

        [Route("first/{author}/{n}/getfirst")]
        public string GetFirst(string author, int n)
        {
            return "GetFirstCalled";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}