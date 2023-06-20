using AutoMapper;
using Microsoft.Extensions.Logging;
using ShoeFactory.Entities;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure.Implementations;

public class PaymentTypeService : TableTypeServiceBase<PaymentType>, IPaymentTypeService
{
    public PaymentTypeService(ILogger<PaymentTypeService> logger,
        IPaymentTypeRepository repository,
        IMapper mapper) : base(logger, repository, mapper)
    {
    }
}