using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using WebMotorsChallenge.CrossCutting.DependencyInjection;
using WebMotorsChallenge.Data;

namespace WebMotorsChallenge.API
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


            var applicationAssembly = AppDomain.CurrentDomain.Load("WebMotorsChallenge.Application");
            services.AddMediatR(applicationAssembly);

            services.AddRepositories();
            services.AddServices();

            services.AddDbContextPool<AdvertisingContext>(
            options => options.UseSqlServer(Configuration.GetConnectionString("TesteWebMotorsDBConnection")));
 
            services.AddSwaggerGen(c=> 
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebMotors", Version = "v1", });
            });

            services.AddAutoMapper(typeof(CrossCutting.AutoMapper.AutoMapperSetup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseHttpsRedirection();
         
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AdvertisingContext>();
                context.Database.EnsureCreated();
            }


            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
}
