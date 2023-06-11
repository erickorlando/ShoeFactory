using Microsoft.EntityFrameworkCore;
using ShoeFactory.Entities;
using ShoeFactory.Persistence;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Repositories.Implementations;

public class ModelRepository : RepositoryBase<Model>, IModelRepository
{
    public ModelRepository(ShoeFactoryDbContext context) : base(context)
    {
    }
}