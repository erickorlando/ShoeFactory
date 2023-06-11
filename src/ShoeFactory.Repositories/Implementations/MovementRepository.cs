using ShoeFactory.Entities;
using ShoeFactory.Persistence;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Repositories.Implementations;

public class MovementRepository : RepositoryBase<Movement>, IMovementRepository
{
    public MovementRepository(ShoeFactoryDbContext context) : base(context)
    {
    }
}