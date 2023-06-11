using ShoeFactory.Dto.Request;
using ShoeFactory.Dto.Response;

namespace ShoeFactory.Infraestructure.Interfaces;

public interface ITableTypeService
{
    Task<BaseResponseCollection<TableTypeDtoResponse>> ListAsync();

    Task<BaseResponseGeneric<TableTypeDtoResponse>> FindById(int id);

    Task<BaseResponseGeneric<int>> AddAsync(TableTypeDtoRequest request);

    Task<BaseResponse> UpdateAsync(int id, TableTypeDtoRequest request);

    Task<BaseResponse> DeleteAsync(int id);
}