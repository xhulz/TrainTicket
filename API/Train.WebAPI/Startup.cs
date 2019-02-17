using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Train.ApplicationCore.Interface.Data;
using Train.ApplicationCore.Interface.Repository;
using Train.ApplicationCore.Interface.Service;
using Train.ApplicationCore.Service;
using Train.Infrastructure.Data;
using Train.Infrastructure.Repository;

namespace Train.WebAPI
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
            services.AddMvc();

			services.AddTransient<IDataContext, DataContext>();
			services.AddTransient<IStationRepository, StationRepository>();
			services.AddTransient<IStationService, StationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

			app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseMvc();
        }
    }
}
