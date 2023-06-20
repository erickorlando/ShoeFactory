using AutoMapper;
using Microsoft.Extensions.Logging;
using ShoeFactory.Entities;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure.Implementations;

public class DocumentTypeService : TableTypeServiceBase<DocumentType>, IDocumentTypeService
{
    public DocumentTypeService(ILogger<DocumentTypeService> logger, 
        IDocumentTypeRepository repository, 
        IMapper mapper) : base(logger, repository, mapper)
    {
    }
}