using System.Collections.Generic;
using DemoWebApp.ApplicationLogic.Interfaces;

namespace DemoWebApp.ApplicationLogic.Services
{
    public class ValuesService : IValues
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public string Get(int id)
        {
            return "value";
        }
        public string AddValue(int id)
        {
            return string.Empty;
        }
    }
}
