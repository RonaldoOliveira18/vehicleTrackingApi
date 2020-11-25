using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using vehicleTrackingApi.Models;
using vehicleTrackingApi.Services;

namespace vehicleTrackingApi
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
            services.Configure<VehicleDatabaseSettings>(
        Configuration.GetSection(nameof(VehicleDatabaseSettings)));

            services.AddSingleton<IVehicleDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<VehicleDatabaseSettings>>().Value);

            services.AddSingleton<IVehicleService, VehicleService>();
            
            services.AddControllers();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Vehicle Tracking",
                    Version = "v2",
                    Description = "Vehicle Tracking",
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>{endpoints.MapControllers();});
            app.UseSwagger();
            app.UseSwaggerUI(options =>options.SwaggerEndpoint("/swagger/v2/swagger.json", "Vehicle Tracking"));
        }
    }
}
