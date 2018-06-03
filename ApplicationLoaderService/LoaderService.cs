using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace Toolkit
{
    public partial class LoaderService : ServiceBase
    {
        protected override void OnStart(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8081");

            config.Routes.MapHttpRoute(
                "API Default", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });

            HttpSelfHostServer server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();
        }

        protected override void OnStop()
        {
        }
    }
}
