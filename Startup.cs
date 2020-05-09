using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using GoingTo_API.Domain.Persistence.Context;
using GoingTo_API.Domain.Repositories;
using GoingTo_API.Persistence;
using GoingTo_API.Domain.Services;
using GoingTo_API.Services;
using GoingTo_API.Persistence.Repositories;
using AutoMapper;

namespace GoingTo_API
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
            services.AddControllers();
            services.AddDbContext<AppDbContext>(options =>
            {
                //options.UseMySQL(Configuration.GetConnectionString("DefaultConnection"))
                //options.UseInMemoryDatabase("goingto-on-memory");

            });
            services.AddScoped<ILocatableRepository, LocatableRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserAchievementRepository, UserAchievementRepository>();
            services.AddScoped<IAchievementRepository, AchievementRepository>();
            
            services.AddScoped<ILocatableService, LocatableService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserAchievementService, UserAchievementService>();
            services.AddScoped<IAchievementService, AchievementService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
           

            services.AddAutoMapper(typeof(Startup));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
