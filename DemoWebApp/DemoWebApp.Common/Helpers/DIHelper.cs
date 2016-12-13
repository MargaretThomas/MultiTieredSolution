using DemoWebApp.ApplicationLogic.Interfaces;
using DemoWebApp.ApplicationLogic.Services;
using DemoWebApp.Data;
using Microsoft.Practices.Unity;
using Nest;

namespace DemoWebApp.Common.Helpers
{
    public class DIHelper
    {
        public static void RegisterComponents<T>(UnityContainer container) where T : LifetimeManager, new()
        {
            container.RegisterType<IValues, ValuesService>(new T());
            container.RegisterType<IElasticClient, AppElasticClient>(new T());
        }
    }
}
