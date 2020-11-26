using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using vehicleTrackingApi.Models;
using vehicleTrackingApi.Repository;
using vehicleTrackingApi.Repository.Interfaces;
using vehicleTrackingApi.Services;
using vehicleTrackingApi.Services.Interfaces;

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
            services.Configure<ConfigMap>(
        Configuration.GetSection(nameof(ConfigMap)));

            services.AddSingleton<IConfigMap>(sp =>
                sp.GetRequiredService<IOptions<ConfigMap>>().Value);

            services.AddSingleton<IVehicleService, VehicleService>();
        
            services.AddSingleton<IVehicleRepository, VehicleRepository>();
            services.AddSingleton<IVehicleHistoryRepository, VehicleHistoryRepository>();
            services.AddSingleton<IAddressRepository, AddressRepository>();
            services.AddSingleton<IAddressService, AddressService>();

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
