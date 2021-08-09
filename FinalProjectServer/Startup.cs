using FinalProjectServer.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using FinalProjectServer.Hubs;
using FinalProjectServer.BL.AirportBL;
using FinalProjectServer.Models;

namespace FinalProjectServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");         
            services.AddDbContextFactory<AirportContext>(options => options.UseSqlServer(connectionString));
            services.AddSingleton<IAirport, Airport>(); 
            services.AddSingleton<INotificationService<AirportImage>, NotificationAdapter>();

            services.AddSignalR();
            services.AddCors(options =>      //connection to react
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("http://localhost:3000") //adress of those who want to start the UI
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });
            });
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
  
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors();

            app.UseEndpoints(endpoints =>  
            {endpoints.MapControllers(); endpoints.MapHub<AirportNotifications>("/notifications");}); //the route for arriving                                                                                                          
        }                                                                                                    //to the hub
    }
}