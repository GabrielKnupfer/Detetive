using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Detetive.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Detetive.Application.Interfaces;
using Detetive.Application.Implementations;
using Detetive.Domain.Repositories;
using Detetive.Infrastructure.Repositories;
using System.Reflection;

namespace Detetive.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var sqlConnectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DetetiveContext>(options => options.UseSqlServer(sqlConnectionString, sqlOptions =>
            {
                sqlOptions.MigrationsAssembly(typeof(Startup).GetTypeInfo().Assembly.GetName().Name);
            }));

            services.AddMvc();

            services.AddScoped<IArmaAppService, ArmaAppService>();
            services.AddScoped<IArmaRepository, ArmaRepository>();
            services.AddScoped<ILocalAppService, LocalAppService>();
            services.AddScoped<ILocalRepository, LocalRepository>();
            services.AddScoped<ISuspeitoAppService, SuspeitoAppService>();
            services.AddScoped<ISuspeitoRepository, SuspeitoRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
