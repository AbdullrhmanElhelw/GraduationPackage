using Infrastructure.DapperQueries.PatientQueries;
using Infrastructure.Database.DapperContext;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure;

public static class InfrastructureDependencyInjection
{
    public static IServiceCollection AddInInfrastructureDependencies(this IServiceCollection services)
    {
        // use Scan to register the configuration classes in the Infrastructure project

        services.Scan(scan => scan
                .FromAssemblies(Assembly.GetExecutingAssembly())
                .AddClasses(classes => classes.Where(type => type.Name.EndsWith("Configuration")))
                .AsImplementedInterfaces()
                .WithScopedLifetime());

        services.Scan(scan => scan
                .FromAssemblies(Assembly.GetExecutingAssembly())
                .AddClasses(classes => classes.Where(type => type.Name.EndsWith("Repository")))
                .AsImplementedInterfaces()
                .WithScopedLifetime());

        // use Scan to register the UnitOfWork class in the Infrastructure project

        services.Scan(scan => scan
                       .FromAssemblies(Assembly.GetExecutingAssembly())
                        .AddClasses(classes => classes.Where(type => type.Name.EndsWith("UnitOfWork")))
                        .AsImplementedInterfaces()
                        .WithScopedLifetime());


        // add Dapper to the project
        services.AddSingleton<DapperDbContext>();
        services.AddTransient<IPatientQuery, PatientQuery>();

        return services;
    }
}
