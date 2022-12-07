using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyAspProject.Modal;

namespace EmptyAspProject {
    public class Startup {
        //CONSTRUCTOR DEPENDENCY INJUCTION
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }
        //free open tools to check your api like swagger, fiddla, postman. know about it briefly

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            //services.AddControllersWithViews();
            //find the difference between  addSingleton(), addTransient(), addScoped()
            //converts json to xml formatt
            services.AddMvc().AddXmlDataContractSerializerFormatters();
            //services.AddMvc();
            services.AddSingleton<IEmployeeRepository, MockEmployyRepository>();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting(); //returns the reference

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(name:"default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
