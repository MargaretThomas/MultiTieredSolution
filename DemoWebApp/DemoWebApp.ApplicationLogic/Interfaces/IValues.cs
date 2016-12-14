using System;
using System.Collections.Generic;

namespace DemoWebApp.ApplicationLogic.Interfaces
{
    public interface IValues
    {
        IEnumerable<string> Get();
        int? Get(Guid id);
        string AddValue(int id);
    }
}
