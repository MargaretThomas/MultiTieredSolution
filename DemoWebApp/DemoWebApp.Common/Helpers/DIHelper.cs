namespace DemoWebApp.Common.Helpers
{
    public class DIHelper
    {
        public static void RegisterComponents<T>(UnityContainer container) where T : LifetimeManager, new()
        {
            container.RegisterType<IValues, ValuesServices>(new T());
        }
    }
}
