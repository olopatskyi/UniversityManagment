using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using AutoMapper;
using DisciplineSwitcher.Application.Extensions;
using DisciplineSwitcher.Application.Shared;
using DisciplineSwitcher.Domain.Models;
using DisciplineSwitcher.Domain.Settings;
using DisciplineSwitcher.Infrastructure.Extensions;
using DisciplineSwitcher.WebApi.Extensions;
using DisciplineSwitcher.WebApi.Middlewares;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DisciplineSwitcher.WebApi;

public class Startup
{
    private IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        });
        
        services.ConfigureBadRequestResponse();

        services.AddHttpClient("HttpClient").ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (sender, certificate, chain, sslPolicyErrors) =>
            {
                return true; // Allow all certificates (not recommended for production)
            };
            return handler;
        });
        
        services
            .AddSwagger()
            .AddSettings(Configuration)
            .AddJwtAuthentication()
            .AddValidation()
            .AddMapper()
            .AddDatabase(() => new DatabaseSettings()
            {
                Server = Configuration.GetValue<string>("DatabaseSettings:Server"),
                Database = Configuration.GetValue<string>("DatabaseSettings:Database"),
                UserId = Configuration.GetValue<string>("DatabaseSettings:UserId"),
                Password = Configuration.GetValue<string>("DatabaseSettings:Password"),
            })
            .AddRepositories()
            .AddIdentity()
            .AddServices()
            .AddObservers()
            .AddFilters()
            .AddFileStorage();
        
        services.AddCors(options =>
        {
            options.AddPolicy("ReactCorsPolicy",
                builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
           
        }

        app.UseStaticFiles();
        app.UseCors("ReactCorsPolicy");
        app.UseMiddleware<ExceptionHandlerMiddleware>();

        app.UseSwagger();
        app.UseSwaggerUI(options => { options.SwaggerEndpoint("/swagger/v1/swagger.json", "CSV File Editor"); });

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

    }
}