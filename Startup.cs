using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration; //(Would get an error message if I don't add these beforehand) <!-- //tinfo200:[2021-03-10-rmatta2-dykstra1] - Add configuration for code.-->  
        }

        public IConfiguration Configuration { get; }

        //(Would get an error message if I don't add these beforehand) <!-- //tinfo200:[2021-03-10-rmatta2-dykstra1] - Add service to container.-->  
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SchoolContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //(Would get an error message if I don't add these beforehand) <!-- //tinfo200:[2021-03-10-rmatta2-dykstra1] - Add to code.-->  
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddControllersWithViews();
        }

        //(Would get an error message if I don't add these beforehand) <!-- //tinfo200:[2021-03-10-rmatta2-dykstra1] - Use method to configure HTTP.-->  
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

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
