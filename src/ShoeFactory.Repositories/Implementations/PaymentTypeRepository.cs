using ShoeFactory.Entities;
using ShoeFactory.Persistence;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Repositories.Implementations;

public class PaymentTypeRepository : RepositoryBase<PaymentType>, IPaymentTypeRepository
{
    public PaymentTypeRepository(ShoeFactoryDbContext context) : base(context)
    {
    }
}