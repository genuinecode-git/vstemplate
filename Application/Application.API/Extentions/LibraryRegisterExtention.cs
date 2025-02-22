
using System.Data;

namespace Application.API.Extentions;

public static class LibraryRegisterExtention
{
    public static IServiceCollection AddLibraryDependancies(this IServiceCollection services, string readonlyConnection)
    {
        // Add services to the container fluent.
        //services.AddControllers()
        //        .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AddTransactionCommandValidator>())
        //        .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AddTransactionCommandValidator>())
        //        .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<StatementRequestValidator>());


        // Register Dapper's IDbConnection for Dependency Injection
        services.AddScoped<IDbConnection>(sp => new SqlConnection(readonlyConnection));

        services.AddAutoMapper(typeof(AutoMapperProfile));

        return services;
    }
}
