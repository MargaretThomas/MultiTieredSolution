using Nest;
using System;

namespace DemoWebApp.Data
{
    public class AppElasticClient : ElasticClient
    {
        public AppElasticClient() : base (new ConnectionSettings(new Uri("http://localhost:9200")).DefaultIndex("values"))
        {

        }
    }
}
