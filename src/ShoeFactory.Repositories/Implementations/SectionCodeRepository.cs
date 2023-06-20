using ShoeFactory.Entities;
using ShoeFactory.Persistence;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Repositories.Implementations;

public class SectionCodeRepository : RepositoryBase<SectionCode>, ISectionCodeRepository
{
    public SectionCodeRepository(ShoeFactoryDbContext context) : base(context)
    {
    }
}