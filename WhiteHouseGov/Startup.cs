using Cloudy.CMS.Routing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WhiteHouseGov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhiteHouseGov
{
    public class Startup
    {
        IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddCloudy(cloudy => cloudy
                .AddAdmin(admin => admin.Unprotect())
                .AddContext<PageContext>()
            );
            services.AddDbContext<PageContext>(options => options
                .UseSqlServer(
                    Configuration.GetConnectionString("sqlserver") ?? throw new Exception("No sqlserver connection string found in appsettings/env"),
                    options => options.EnableRetryOnFailure()
                )
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCloudyAdminStaticFilesFromPath(@"..\..\Cloudy.CMS\Cloudy.CMS.UI\wwwroot");
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapCloudyAdminRoutes();
                endpoints.MapControllerRoute(null, "/{**route:contentroute}", new { controller = "Page", action = "Index" });
            });
        }
    }
}
