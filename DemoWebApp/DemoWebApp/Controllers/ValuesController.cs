using DemoWebApp.ApplicationLogic.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace DemoWebApp.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IValues _iValues;

        public ValuesController(IValues iValues)
        {
            _iValues = iValues;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return _iValues.Get();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return _iValues.Get(id);
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
