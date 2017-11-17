using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SpringBootApp.Entities;
using Microsoft.EntityFrameworkCore;
using SpringBootApp.Repositories;
using SpringBootApp.Services;

namespace SpringBootApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<SpringBootAppContext>();
            services.AddScoped<SpringBootAppRepository>();
            services.AddScoped<SpringBootAppService>();
            services.AddDbContext<SpringBootAppContext>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=platemaster;Integrated Security=True;Connect Timeout=30"));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}