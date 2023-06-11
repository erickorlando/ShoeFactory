using ShoeFactory.Entities;
using ShoeFactory.Persistence;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Repositories.Implementations;

public class CurrencyRepository : RepositoryBase<Currency>, ICurrencyRepository
{
    public CurrencyRepository(ShoeFactoryDbContext context) : base(context)
    {

    }
}