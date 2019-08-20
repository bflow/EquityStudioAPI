using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.WsFederation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.AspNetCore.Authentication;

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
            services.AddAuthentication(o =>
            {
                o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                o.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = WsFederationDefaults.AuthenticationScheme;
            })
            .AddWsFederation(o =>
            {
                o.Wtrealm = "api://5006ad8e-908e-4d0e-b24e-e486985b86e7";
                o.MetadataAddress = "https://login.microsoftonline.com/e38abc00-3580-438b-8571-484d11b42eb5/federationmetadata/2007-06/federationmetadata.xml";

            })
            .AddCookie();

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

            app.UseAuthentication();
            app.Use(async (context, next) =>
            {
                
                if (!context.User.Identity.IsAuthenticated && context.Request.Path != "/signin-wsfed")
                {
                    await context.ChallengeAsync(WsFederationDefaults.AuthenticationScheme);
                }
                else
                {
                    await next();
                }
            });
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
