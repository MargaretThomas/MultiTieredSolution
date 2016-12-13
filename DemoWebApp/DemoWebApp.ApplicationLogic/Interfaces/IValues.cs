using System.Collections.Generic;

namespace DemoWebApp.ApplicationLogic.Interfaces
{
    public interface IValues
    {
        IEnumerable<string> Get();
        string Get(int id);
        string AddValue(int id);
    }
}
