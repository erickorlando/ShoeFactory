using ShoeFactory.Entities;
using ShoeFactory.Persistence;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Repositories.Implementations;

public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(ShoeFactoryDbContext context) 
        : base(context)
    {

    }
}