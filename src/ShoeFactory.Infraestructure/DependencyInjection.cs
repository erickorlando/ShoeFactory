using Microsoft.Extensions.DependencyInjection;
using ShoeFactory.Infraestructure.Implementations;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Infraestructure.Profiles;
using ShoeFactory.Repositories.Implementations;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure;

public static class DependencyInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services.AddTransient<ICategoryRepository, CategoryRepository>();
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services.AddTransient<ICategoryService, CategoryService>();
    }

    public static IServiceCollection AddMappers(this IServiceCollection services)
    {
        return services.AddAutoMapper(config =>
        {
            config.AddProfile<TableTypeProfile>();
        });
    }
}