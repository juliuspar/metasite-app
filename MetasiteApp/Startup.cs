using System;
using MetasiteApp.Phones.Calls;
using MetasiteApp.Phones.Data;
using MetasiteApp.Phones.Smses;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MetasiteApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration) 
            => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "clientapp/build";
            });
            services.
                AddScoped<CallsRepository>().
                AddScoped<SmsRepository>().
                AddDbContext<TspDatabaseContext>(
                    o => o.UseSqlServer(Configuration.GetConnectionString("TspDatabaseConnection")));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            EnsureDatabaseIsCreated(app);
            
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseExceptionHandler("/Error");

            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseMvc(routes => 
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
            app.UseSpa(spa => 
            {
                spa.Options.SourcePath = "clientapp";

                if (env.IsDevelopment())
                    spa.UseReactDevelopmentServer(npmScript: "start");
            });
        }

        private static void EnsureDatabaseIsCreated(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<TspDatabaseContext>();
                context.Database.EnsureCreated();
            }
        }
    }
}
