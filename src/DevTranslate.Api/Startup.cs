using DevTranslate.Api.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DevTranslate.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment Environment { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
                }
            );

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod();
                });
            });

            services.AddDbContext<DevTranslateContext>(optionsBuilder =>
            {
                optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DevTranslateConnectionString"));
            });

            services.AddSwaggerGen(c => 
            { 
                c.SwaggerDoc("v2", new OpenApiInfo
                {
                    Title = "Devtranslate API",
                    Version = "v2",
                    Description = "Welcome! The Devtranslate API is currently in its second version and was created to support the open source Devtranslate cataloging and translation project.",
                    Extensions = new Dictionary<string, IOpenApiExtension>
                    {
                      { "x-logo", new OpenApiObject
                        {
                           { "url", new OpenApiString("https://devtranslate.io/assets/images/logo-vertical.svg") },
                           { "altText", new OpenApiString("Devtranslate Logo") }
                        }
                      }
                    }
                });
                c.EnableAnnotations();
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsProduction())
            {
                app.UseForwardedHeaders(new ForwardedHeadersOptions
                {
                    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
                });
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors();

            app.UseSwagger();

            app.UseStaticFiles();

            app.UseReDoc(c =>
            {
                c.RoutePrefix = "";
                c.DocumentTitle = "Devtranslate API V2";
                c.SpecUrl("/swagger/v2/swagger.json");
                c.SortPropsAlphabetically();
                c.HideDownloadButton();
                c.DisableSearch();
                c.InjectStylesheet("/assets/redoc-style.css");
                c.ConfigObject.AdditionalItems.Add("theme", new
                {
                    typography = new
                    {
                        fontWeightBold = "300",
                        fontFamily = "Cera Round Pro, sans-serif",
                        headings = new
                        {
                            fontFamily = "Cera Round Pro, sans-serif",
                        }
                    },
                    logo = new
                    {
                        gutter = "20px"
                    },
                    colors = new
                    {
                        primary = new
                        {
                            main = "#fc5156"
                        },
                    }
                });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
