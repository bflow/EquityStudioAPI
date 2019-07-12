using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace EquityStudioAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddHttpClient();
            services.AddHttpClient(Configuration["API:IEXsandbox:Client"], c =>
            {
                c.BaseAddress = new Uri(Configuration["API:IEXsandbox:BaseUrl"]);
            });
            services.AddHttpClient(Configuration["API:IEX:Client"], c =>
            {
                c.BaseAddress = new Uri(Configuration["API:IEX:BaseUrl"]);
            });
            services.AddHttpClient(Configuration["API:Quandl:Client"], c =>
            {
                c.BaseAddress = new Uri(Configuration["API:Quandl:BaseUrl"]);
            });
            services.AddHttpClient(Configuration["API:AlphaVantage:Client"], c =>
            {
                c.BaseAddress = new Uri(Configuration["API:AlphaVantage:BaseUrl"]);
            });
            services.AddHttpClient(Configuration["API:Finbox:Client"], c =>
            {
                c.BaseAddress = new Uri(Configuration["API:Finbox:BaseUrl"]);
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Equity Studio API", Version = "v0.5b" });
            });

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "EquityStudioAPI v0.5b");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
