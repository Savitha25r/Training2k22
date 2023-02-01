using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrj1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
             services.AddControllersWithViews();
            //  services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //user defined middlewares
            //first middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Middleware 1 : Request \n");
            //    await next();
            //    await context.Response.WriteAsync("Middleware 1 : Response \n");
            //});

            //second middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Middleware 2 : Request \n");
            //    await next();
            //    await context.Response.WriteAsync("Middleware 2 : Response \n");
            //});
            ////terminal middleware
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Middleware 3 : Both Request and Response \n");
            //});
            //app.UseHttpsRedirection();

            

            app.UseStaticFiles();

            app.UseRouting();

            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");

                //endpoints.MapGet("/", async context =>
                // {
                     //1.
                     //await context.Response.WriteAsync("Hello World");
                     //2.                      await context.Response.WriteAsync("Worker Process name:" +
                        //System.Diagnostics.Process.GetCurrentProcess().ProcessName);
                 });
            //});
        }
    }
}
