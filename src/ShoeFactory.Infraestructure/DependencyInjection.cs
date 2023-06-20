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
        return services.AddTransient<ICategoryRepository, CategoryRepository>()
            .AddTransient<ICurrencyRepository, CurrencyRepository>()
            .AddTransient<IDocumentTypeRepository, DocumentTypeRepository>()
            .AddTransient<ILeatherRepository, LeatherRepository>()
            .AddTransient<IModelRepository, ModelRepository>()
            .AddTransient<IMovementRepository, MovementRepository>()
            .AddTransient<IPaymentTypeRepository, PaymentTypeRepository>()
            .AddTransient<ISectionCodeRepository, SectionCodeRepository>();
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services.AddTransient<ICategoryService, CategoryService>()
            .AddTransient<ICurrencyService, CurrencyService>()
            .AddTransient<IDocumentTypeService, DocumentTypeService>()
            .AddTransient<ILeatherService, LeatherService>()
            .AddTransient<IModelService, ModelService>()
            .AddTransient<IMovementService, MovementService>()
            .AddTransient<IPaymentTypeService, PaymentTypeService>()
            .AddTransient<ISectionCodeService, SectionCodeService>();
    }

    public static IServiceCollection AddMappers(this IServiceCollection services)
    {
        return services.AddAutoMapper(config =>
        {
            config.AddProfile<TableTypeProfile>();
        });
    }
}