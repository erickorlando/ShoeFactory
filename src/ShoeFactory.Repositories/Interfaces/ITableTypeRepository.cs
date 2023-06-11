using ShoeFactory.Entities;

namespace ShoeFactory.Repositories.Interfaces;

public interface ITableTypeRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : TableTypeBase
{
    
}