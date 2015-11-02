using Microsoft.AspNet.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAT.Web.Globals
{
    public class RouteConfig
    {
        public static void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes => {
                routes.MapRoute("Default", "{controller=home}/{action=index}/{id?}");
            });

            app.RunIISPipeline();
        }
    }
}
