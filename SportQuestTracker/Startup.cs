using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportQuestTracker.Contracts;
using SportQuestTracker.Data;
using SportQuestTracker.Mappings;
using SportQuestTracker.Models;
using SportQuestTracker.Models.MockRepositories;
using SportQuestTracker.Models.Repositories;
using SportQuestTracker.Services;

namespace SportQuestTracker
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
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IGadgetRepository, GadgetRepository>(); 
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddRazorPages();
            
            //services.AddCors(o =>
            //{
            //    o.AddPolicy("CorsPolicy", 
            //        builder => builder.AllowAnyOrigin()
            //                                        .AllowAnyMethod()
            //                                        .AllowAnyHeader());
            //});

            services.AddAutoMapper(typeof(Maps));
<<<<<<< HEAD
            services.AddSingleton<ILoggerService, LoggerService>();
            services.AddControllersWithViews();
=======

            services.AddSingleton<ILoggerService, LoggerService>();

>>>>>>> be9864d3ed9da9c5ef9a00c5f1947490cef1cca8
            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseDeveloperExceptionPage();
<<<<<<< HEAD
=======

>>>>>>> be9864d3ed9da9c5ef9a00c5f1947490cef1cca8
            app.UseHttpsRedirection();
            app.UseCors("CorsPolicy");
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {        
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}                                 