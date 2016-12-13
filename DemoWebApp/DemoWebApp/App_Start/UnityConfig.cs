using Microsoft.Practices.Unity;
using System.Web.Http;
using Microsoft.Owin.Security.DataProtection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Mvc;
using MvcUnityDependencyResolver = Unity.Mvc5.UnityDependencyResolver;
using WebApiUnityDependencyResolver = Unity.WebApi.UnityDependencyResolver;
using DemoWebApp.Common.Helpers;
namespace DemoWebApp
{
    public static class UnityConfig
    {
            public static UnityContainer RegisterComponents(IDataProtectionProvider dataProtectionProvider)
        {
            var container = new UnityContainer();

            DIHelper.RegisterComponents<HierarchicalLifetimeManager>(container);

            var settings = new JsonSerializerSettings();
#if DEBUG
            settings.Formatting = Formatting.Indented;
#else
            settings.Formatting = Formatting.None;
#endif
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            var jsonSerializer = JsonSerializer.Create(settings);
            container.RegisterInstance(jsonSerializer);

            DependencyResolver.SetResolver(new MvcUnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new WebApiUnityDependencyResolver(container);

            return container;
        }
    }
}
