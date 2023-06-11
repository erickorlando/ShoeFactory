using AutoMapper;
using Microsoft.Extensions.Logging;
using ShoeFactory.Dto.Request;
using ShoeFactory.Dto.Response;
using ShoeFactory.Entities;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure.Implementations;

public class TableTypeService<TEntity> : ITableTypeService
where TEntity : TableTypeBase
{
    private readonly ITableTypeRepository<TEntity> _repository;
    private readonly ILogger<TableTypeService<TEntity>> _logger;
    private readonly IMapper _mapper;

    public TableTypeService(ITableTypeRepository<TEntity> repository, ILogger<TableTypeService<TEntity>> logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }
    public async Task<BaseResponseCollection<TableTypeDtoResponse>> ListAsync()
    {
        var response = new BaseResponseCollection<TableTypeDtoResponse>();
        try
        {
            var collection = await _repository.ListAsync(p => p.Status);
            response.Data = _mapper.Map<ICollection<TableTypeDtoResponse>>(collection);
            response.Success = true;
        }
        catch (Exception ex)
        {
            _logger.LogCritical(ex, "Error al listar {Message}", ex.Message);
            response.ErrorMessage = ex.Message;
        }

        return response;
    }

    public Task<BaseResponseGeneric<TableTypeDtoResponse>> FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseGeneric<int>> AddAsync(TableTypeDtoRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse> UpdateAsync(int id, TableTypeDtoRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}
