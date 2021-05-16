using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = true);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //when a url such as anotherone/32 is called, another_v2 will be used intead of anotherone because the first added rule is used first. from top to bottom checking, if the engine finds a matching rule, no more rules is checked anymore
            //            app.UseMvc(
            //routes => routes.MapRoute("another_v2", "anotherone/{id?}", new { controller = "Home", action = "Index" })
            //    );

            //            app.UseMvc(
            //                routes => routes.MapRoute("CustomRoute", "Products/List/", new { controller = "Home", action = "Index" }).MapRoute("IndexRoute", "index", new { controller = "Home", action = "Index" })
            //);

            //            app.UseMvc(
            //    routes => routes.MapRoute("anotherone", "anotherone/{id?}", new { controller = "Home", action = "parameterPass" })
            //                );

            //            app.UseMvc(
            //routes => routes.MapRoute("testv2", "test2", new { controller = "Home", action = "parameterPass" })
            //    );

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            //    app.UseEndpoints(endpoints =>
            //    {
            //        endpoints.MapControllerRoute(
            //name: "default",
            //pattern: "/lecture7/{userid?}");
            //    });


        }
    }
}
