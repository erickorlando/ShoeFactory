using ShoeFactory.Entities;
using ShoeFactory.Persistence;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Repositories.Implementations;

public class LeatherRepository : RepositoryBase<Leather>, ILeatherRepository
{
    public LeatherRepository(ShoeFactoryDbContext context) : base(context)
    {
    }
}