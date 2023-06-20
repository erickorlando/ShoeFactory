using AutoMapper;
using Microsoft.Extensions.Logging;
using ShoeFactory.Entities;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure.Implementations;

public class ModelService : TableTypeServiceBase<Model>, IModelService
{
    public ModelService(ILogger<ModelService> logger,
        IModelRepository repository,
        IMapper mapper) : base(logger, repository, mapper)
    {
    }
}