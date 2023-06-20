using ShoeFactory.Dto.Request;
using ShoeFactory.Dto.Response;
using ShoeFactory.Entities;

namespace ShoeFactory.Infraestructure.Interfaces;

public interface ITableTypeService<TEntity>
where TEntity : TableTypeBase
{
    Task<BaseResponseCollection<TableTypeDtoResponse>> ListAsync(string? filter);

    Task<BaseResponse> AddAsync(TableTypeDtoRequest request);

    Task<BaseResponse> UpdateAsync(int id, TableTypeDtoRequest request);

    Task<BaseResponseGeneric<TableTypeDtoResponse>> GetAsync(int id);

    Task<BaseResponse> DeleteAsync(int id);
}