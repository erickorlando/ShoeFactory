using ShoeFactory.Entities;
using ShoeFactory.Persistence;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Repositories.Implementations;

public class DocumentTypeRepository : RepositoryBase<DocumentType>, IDocumentTypeRepository
{
    public DocumentTypeRepository(ShoeFactoryDbContext context) : base(context)
    {
    }
}