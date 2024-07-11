using sample.API.Authorization;
using sample.API.Middlewares;
using sample.API.Configurations;
using sample.Application;
using sample.Domain;
using sample.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Serilog;

namespace sample.API;

public static class Startup
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddDomainLayer();
        builder.Services.AddApplicationLayer();
        builder.Services.AddInfrastructureLayer(builder.Configuration);
        
        builder.Services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
        builder.Services.AddSingleton<IAuthorizationHandler, PermissionHandler>();
        
        builder.ConfigureControllers();
        builder.ConfigureAuthentication();
        builder.ConfigureCors();
        builder.ConfigureLogger();
        builder.ConfigureSwagger();
        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseSerilogRequestLogging();
        
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.UseHttpsRedirection();
        app.UseCors(app.Environment.IsDevelopment() ? "AnyCors" : "DefaultCors");

        app.UseAuthentication();
        app.UseAuthorization();
        
        app.UseCustomExceptionHandler();
        app.MapControllers();
        return app;
    }
}
