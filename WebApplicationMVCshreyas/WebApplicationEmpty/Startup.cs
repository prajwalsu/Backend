using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEmpty.Modal;

namespace WebApplicationEmpty
{
    public class Startup
    {
        public IConfiguration Configuration { get; } //read key value pair->IConfiguration
        public Startup(IConfiguration configuration) {//constructor
            Configuration = configuration;
        }
            // This method gets called by the runtime. Use this method to add services to the container.
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            public void ConfigureServices(IServiceCollection services) {
            services.AddControllersWithViews();
            //services.AddMvc();

            //convert json to xml format
              services.AddMvc().AddXmlDataContractSerializerFormatters();//break objects into packages.




            //services.AddMvcCore();

            //connectivity
            services.AddSingleton<IEmployRepository, MockEmployRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                
            }


            app.UseRouting(); //returns reference

            app.UseEndpoints(endpoints => {   //fetch reference from endpoints.
                endpoints.MapControllerRoute(
                    name: "default",
                     pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}

