using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TgJobsApi.Services;
using TgJobsAPI.Services;

namespace TgJobsApi
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

            // DI Abstraction
            RegisterService(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseMvc();
        }

        // Adding dependencies from another layers (isolated from Service)
        private static void RegisterService(IServiceCollection services)
        {
            services.AddSingleton<CustomerService>();
            services.AddSingleton<SalesOrderHeaderService>();
            services.AddSingleton<ProductService>();
            Infrastructure.Crosscutting.SimpleInjectorBootStrapper.RegisterService(services);
        }
    }
}
