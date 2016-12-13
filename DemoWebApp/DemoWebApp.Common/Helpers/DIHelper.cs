using DemoWebApp.ApplicationLogic.Interfaces;
using DemoWebApp.ApplicationLogic.Services;
using Microsoft.Practices.Unity;

namespace DemoWebApp.Common.Helpers
{
    public class DIHelper
    {
        public static void RegisterComponents<T>(UnityContainer container) where T : LifetimeManager, new()
        {
            container.RegisterType<IValues, ValuesService>(new T());
        }
    }
}
