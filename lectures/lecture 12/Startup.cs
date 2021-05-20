using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.Configure<MyOptions>(_configuration);
            services.AddMvc(options => options.EnableEndpointRouting = true);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Error");//this page will be called whenever an internal unhandled exception occurs if the environment is not development
            //}

            app.UseExceptionHandler("/Error");

            //app.UseStatusCodePages();

            //app.UseStatusCodePages(async context =>
            //{
            //    context.HttpContext.Response.ContentType = "text/html";

            //    if (context.HttpContext.Response.StatusCode.ToString().StartsWith("4"))
            //    {
            //        GlobalMethods.logErrors(null, context.HttpContext.Response);

                   

            //         await context.HttpContext.Response.WriteAsync(
            //        "We're <b>really</b> sorry, but something went wrong. Error code: " +
            //        context.HttpContext.Response.StatusCode);
            //    }
            //});
            
            //this approach is better
            app.UseStatusCodePagesWithReExecute("/Error404", "?irErrorCode={0}");

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

            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = new PhysicalFileProvider
                (
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images")
                ),
                RequestPath = "/images"
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
