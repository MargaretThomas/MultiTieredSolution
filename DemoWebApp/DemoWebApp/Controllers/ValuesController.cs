using DemoWebApp.ApplicationLogic.Interfaces;
using System;
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
        public IEnumerable<int> Get()
        {
            return _iValues.Get();
        }

        // GET api/values/5
        public int? Get(Guid id)
        {
            return _iValues.Get(id);
        }

        // POST api/values
        public string Post([FromBody]int value)
        {
            return _iValues.AddValue(value);
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
