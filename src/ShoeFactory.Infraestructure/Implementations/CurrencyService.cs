using AutoMapper;
using Microsoft.Extensions.Logging;
using ShoeFactory.Entities;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure.Implementations;

public class CurrencyService : TableTypeServiceBase<Currency>, ICurrencyService
{
    public CurrencyService(ILogger<CurrencyService> logger, 
        ICurrencyRepository repository, 
        IMapper mapper) : base(logger, repository, mapper)
    {
    }
}