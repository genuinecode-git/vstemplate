﻿
namespace ApplicationTemplate.API.Extentions;

public static class InfrastructureExtention
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ISampleRepository, SampleRepository>();

        services.AddScoped<ISampleQueries, SampleQueries>();


        return services;
    }
}
