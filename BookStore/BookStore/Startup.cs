using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from middleware-1-Request||");
            //    await next();
            //    await context.Response.WriteAsync("Hello from middleware-1-Response||");
            //});

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from middleware-2-Request||");
            //    await next();
            //    await context.Response.WriteAsync("Hello from middleware-2-Response||");

            //});

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from middleware-3-Request||");
            //    await next();
            //});

            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions() { 
            FileProvider=new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"MyStaticFiles")),
            RequestPath="/MyStaticFiles"
            });

            app.UseRouting();

            app.UseEndpoints(endpoint => {
                //endpoint.MapDefaultControllerRoute();
                endpoint.MapControllerRoute(
                    name: "Default",
                    pattern: "bookstore/{Controller=Home}/{action=Index}/{id?}");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World from my MVC app!");
            //    });
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/dj", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello DJ from my MVC app!");
            //    });
            //});
        }
    }
}
