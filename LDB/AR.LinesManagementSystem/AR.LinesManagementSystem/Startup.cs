using AR.LinesManagementSystem.Context;
using AR.LinesManagementSystem.DbEntities;
using AR.LinesManagementSystem.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace AR.LinesManagementSystem
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Create the policy for CORS for cross-domain
            services.AddCors(o => o.AddPolicy("EnableRequestPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            
            // Add framework services.
            services.AddMvc()
                .AddMvcOptions(o =>
                                o.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter())
                              );

            services.AddDbContext<ArDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ARDbConnection")));

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //var config = new AutoMapper.MapperConfiguration(o =>
            //{
            //    o.AddProfile(new AutomapperProfile());
            //});
            //var mapper = config.CreateMapper();
            //services.AddSingleton<IMapper>(mapper);

            services.AddAutoMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, ArDBContext context)
        {
            try
            {
                //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
                loggerFactory.AddFile("Logs/ARLineManagementSystem-{Date}.txt");

                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                    app.UseBrowserLink();
                }
                else
                {
                    app.UseExceptionHandler("/Home/Error");
                }
                app.UseCors("EnableRequestPolicy");
                app.UseStatusCodePages();
                app.UseStaticFiles();
                app.UseMvcWithDefaultRoute();
                DbInitializer.Initialize(context);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
