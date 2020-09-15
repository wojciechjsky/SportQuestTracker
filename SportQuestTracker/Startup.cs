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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
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
            
            services.AddCors(o =>
            {
                o.AddPolicy("CorsPolicy", 
                    builder => builder.AllowAnyOrigin()
                                                    .AllowAnyMethod()
                                                    .AllowAnyHeader());
            });

            services.AddAutoMapper(typeof(Maps));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("version1", new OpenApiInfo
                {
                    Title = "SportQuestTracker API", 
                    Version = "version1",
                    Description = "Track your sport activities and change it for gadgets!"
                });
                var xfile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xpath = Path.Combine(AppContext.BaseDirectory, xfile);
                c.IncludeXmlComments(xpath);

            });


            services.AddSingleton<ILoggerService, LoggerService>();


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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(e =>
            {
                e.SwaggerEndpoint("/swagger/version1/swagger.json", "SportQuestTracker API");
                e.RoutePrefix = "";
            });
            app.UseHttpsRedirection();

            app.UseCors("CorsPolicy");


            app.UseRouting();
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
