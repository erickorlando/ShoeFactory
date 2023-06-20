using AutoMapper;
using Microsoft.Extensions.Logging;
using ShoeFactory.Entities;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure.Implementations;

public class LeatherService : TableTypeServiceBase<Leather>, ILeatherService
{
    public LeatherService(ILogger<LeatherService> logger,
        ILeatherRepository repository,
        IMapper mapper) : base(logger, repository, mapper)
    {
    }
}