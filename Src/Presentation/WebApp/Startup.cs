using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nexawo.Application;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nexawo.Application.Common.Interfaces;
using Nexawo.Persistence;
using WebApp.Services;
using Nexawo.Persistence;
using Nexawo.Infrastructure;
using AutoMapper;
using System.Reflection;
using WebApp.Common.Mapping;

namespace Nexawo.WebApp
{
    public class Startup
    {
        private IServiceCollection _services;
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddInfrastructure(Configuration, Environment);
            services.AddPersistence(Configuration);
            services.AddApplication();

            services.AddHealthChecks()
                .AddDbContextCheck<MainDbContext>();

            services.AddScoped<ICurrentUserService, CurrentUserService>();
            //services.AddScoped<Nexawo.Application.Tenants.Commands.CreateTenant.CreateTenantCommand>();
            services.AddHttpContextAccessor();

            services
                .AddControllersWithViews()
                .AddNewtonsoftJson()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<IMainDbContext>());

            services.AddRazorPages();            
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(6);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            AutoMappings.InitializeAutoMapper(services);
            
            _services = services;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
       {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                RegisteredServicesPage(app);
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseCustomExceptionHandler();
            app.UseHealthChecks("/health");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseSpaStaticFiles();

            //app.UseOpenApi();
            //
            //app.UseSwaggerUi3(settings =>
            //{
            //    settings.Path = "/api";
            //    //    settings.DocumentPath = "/api/specification.json";   Enable when NSwag.MSBuild is upgraded to .NET Core 3.0
            //});

            app.UseRouting();

            app.UseAuthentication();
            //app.UseIdentityServer();
            app.UseAuthorization();
            app.UseSession();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });

        }
        private void RegisteredServicesPage(IApplicationBuilder app)
        {
            app.Map("/services", builder => builder.Run(async context =>
            {
                var sb = new StringBuilder();
                sb.Append("<h1>Registered Services</h1>");
                sb.Append("<table><thead>");
                sb.Append("<tr><th>Type</th><th>Lifetime</th><th>Instance</th></tr>");
                sb.Append("</thead><tbody>");
                foreach (var svc in _services)
                {
                    sb.Append("<tr>");
                    sb.Append($"<td>{svc.ServiceType.FullName}</td>");
                    sb.Append($"<td>{svc.Lifetime}</td>");
                    sb.Append($"<td>{svc.ImplementationType?.FullName}</td>");
                    sb.Append("</tr>");
                }
                sb.Append("</tbody></table>");
                await context.Response.WriteAsync(sb.ToString());
            }));
        }
    }
}
