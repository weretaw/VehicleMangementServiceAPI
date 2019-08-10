using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using VehicleMangementService.Models;
using Microsoft.EntityFrameworkCore;

namespace VehicleMangementService
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
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
      services.AddSwaggerGen(
        s =>
        {
          s.SwaggerDoc("v1",new Info {Title= "VehicleMangementService API", Description= "Swagger VehicleMangementService API" });

          var xmlPath = System.AppDomain.CurrentDomain.BaseDirectory + @"VehicleMangementService.xml";
          s.IncludeXmlComments(xmlPath);
        }
        );
  
      var connection = @"Server=.\SQLEXPRESS17;Database=VehicleMangement;Trusted_Connection=True;";
      services.AddDbContext<VehicleContext>(options => options.UseSqlServer(connection));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseMvc();
      app.UseSwagger();
      app.UseSwaggerUI(s =>
      {
        s.SwaggerEndpoint("/swagger/v1/swagger.json", "VehicleMangementService API");
      }
      );
    }
  }
}
