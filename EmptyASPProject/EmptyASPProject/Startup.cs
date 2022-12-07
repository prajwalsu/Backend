
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyASPProject
{
    public class Startup
    {

        public IConfiguration Configuration { get; } ////read key value pair->IConfiguration
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }// not present in empty file, it is taken from mvc file



        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            //app.UseDefaultFiles(); returns default,index and others html files.

            //DefaultFilesOptions defaultFilesOptions =
            //    new DefaultFilesOptions();//to render our own default file

            // //clear all previous default files
            // defaultFilesOptions.DefaultFileNames.Clear();
            // //add default file name
            // defaultFilesOptions.DefaultFileNames.Add("Landing.html");


            // app.UseDefaultFiles(defaultFilesOptions);//render it
            // app.UseStaticFiles();

            //app.UseHttpsRedirection();
            


            //app.UseFileServer is a combination of both default files and static files

            FileServerOptions fileServerOptions = new FileServerOptions();
           fileServerOptions.EnableDefaultFiles = true;
          
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("New.html");
            fileServerOptions.StaticFileOptions.RedirectToAppendTrailingSlash = true;
            app.UseFileServer(fileServerOptions);

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapGet("/", async context => {
                    await context.Response.WriteAsync("hello World");//development.json(Configuration["privateKey"]);
                });
            });
        }
    }
}