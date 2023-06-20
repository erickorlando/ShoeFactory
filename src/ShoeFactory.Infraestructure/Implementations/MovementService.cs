using AutoMapper;
using Microsoft.Extensions.Logging;
using ShoeFactory.Entities;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure.Implementations;

public class MovementService : TableTypeServiceBase<Movement>, IMovementService
{
    public MovementService(ILogger<MovementService> logger,
        IMovementRepository repository,
        IMapper mapper) : base(logger, repository, mapper)
    {
    }
}