using AutoMapper;
using Microsoft.Extensions.Logging;
using ShoeFactory.Entities;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure.Implementations;

public class SectionCodeService : TableTypeServiceBase<SectionCode>, ISectionCodeService
{
    public SectionCodeService(ILogger<SectionCodeService> logger,
        ISectionCodeRepository repository,
        IMapper mapper) : base(logger, repository, mapper)
    {
    }
}