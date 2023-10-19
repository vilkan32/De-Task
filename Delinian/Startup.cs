using Delinian.Interfaces;
using Delinian.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Delinian.Context;

namespace Delinian
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
            services.AddScoped<IReadService, ReadService>();
            services.AddScoped<IWriteService, WriteService>();
            services.AddDbContext<DelinianContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("Delinian")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            using var scoperService = app.ApplicationServices.CreateScope();

            var services = scoperService.ServiceProvider;

            using var context = services.GetRequiredService<DelinianContext>();

            context.Database.Migrate();


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
