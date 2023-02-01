using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staticfiles_Prj
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
            }

            //the below is to make our own page as the index page using
            //DefaultFilesOptions dfo = new DefaultFilesOptions();
            //dfo.DefaultFileNames.Clear();
            //dfo.DefaultFileNames.Add("MyPage.html");

            //app.UseDefaultFiles(dfo);
            //app.UseStaticFiles();

            //To avoid using both DefaultFiles and StaticFiles Middleware,
            //we can just replace both with FileServerOption

            FileServerOptions fso = new FileServerOptions();
            fso.DefaultFilesOptions.DefaultFileNames.Clear();
            fso.DefaultFilesOptions.DefaultFileNames.Add("MyPage.html");
            app.UseFileServer(fso);


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
