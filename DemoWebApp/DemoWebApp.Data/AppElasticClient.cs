using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Data
{
    public class AppElasticClient : ElasticClient
    {
        AppElasticClient() : base (new Uri("htpp://localhost:9200")) { }
    }
}
