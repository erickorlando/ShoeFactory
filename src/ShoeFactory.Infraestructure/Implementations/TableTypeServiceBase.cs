using AutoMapper;
using Microsoft.Extensions.Logging;
using ShoeFactory.Dto.Request;
using ShoeFactory.Dto.Response;
using ShoeFactory.Entities;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure.Implementations;

public abstract class TableTypeServiceBase<TEntity> : ITableTypeService<TEntity>
where TEntity : TableTypeBase
{
    protected readonly ILogger<TableTypeServiceBase<TEntity>> Logger;
    protected readonly IRepositoryBase<TEntity> Repository;
    protected readonly IMapper Mapper;

    protected TableTypeServiceBase(
        ILogger<TableTypeServiceBase<TEntity>> logger,
        IRepositoryBase<TEntity> repository,
        IMapper mapper)
    {
        Logger = logger;
        Repository = repository;
        Mapper = mapper;
    }

    public async Task<BaseResponseCollection<TableTypeDtoResponse>> ListAsync(string? filter)
    {
        var response = new BaseResponseCollection<TableTypeDtoResponse>();
        try
        {
            var data = await Repository.ListAsync(p => p.Description.Contains(filter ?? string.Empty));
            response.Data = Mapper.Map<ICollection<TableTypeDtoResponse>>(data);
            response.Success = true;
        }
        catch (Exception ex)
        {
            response.ErrorMessage = $"Error al listar los registros de {typeof(TEntity).Name}";
            Logger.LogError(ex, "{ResponseMessage} {Message}", response.ErrorMessage, ex.Message);
        }

        return response;
    }

    public async Task<BaseResponse> AddAsync(TableTypeDtoRequest request)
    {
        var response = new BaseResponse();
        try
        {
            var entity = Mapper.Map<TEntity>(request);
            await Repository.AddAsync(entity);

            response.Success = true;
        }
        catch (Exception ex)
        {
            response.ErrorMessage = $"Error al Agregar {typeof(TEntity).Name}";
            Logger.LogError(ex, "{ResponseMessage} {Message}", response.ErrorMessage, ex.Message);
        }
        return response;
    }

    public async Task<BaseResponse> UpdateAsync(int id, TableTypeDtoRequest request)
    {
        var response = new BaseResponse();

        try
        {
            var entity = await Repository.FindAsync(id);
            if (entity is null)
                throw new InvalidOperationException("No se encontró el registro");

            Mapper.Map(request, entity);

            await Repository.UpdateAsync();

            response.Success = true;
        }
        catch (Exception ex)
        {
            response.ErrorMessage = $"Error al Actualizar {typeof(TEntity).Name}";
            Logger.LogError(ex, "{ResponseMessage} {Message}", response.ErrorMessage, ex.Message);
        }

        return response;
    }

    public async Task<BaseResponseGeneric<TableTypeDtoResponse>> GetAsync(int id)
    {
        var response = new BaseResponseGeneric<TableTypeDtoResponse>();

        try
        {
            var entity = await Repository.FindAsync(id);
            if (entity is null)
                throw new InvalidOperationException("No se encontró el registro");

            response.Data = Mapper.Map<TableTypeDtoResponse>(entity);
            response.Success = true;
        }
        catch (Exception ex)
        {
            response.ErrorMessage = $"Error al Obtener {typeof(TEntity).Name}";
            Logger.LogError(ex, "{ResponseMessage} {Message}", response.ErrorMessage, ex.Message);
        }

        return response;
    }

    public async Task<BaseResponse> DeleteAsync(int id)
    {
        var response = new BaseResponse();

        try
        {
            var entity = await Repository.FindAsync(id);
            if (entity is null)
                throw new InvalidOperationException("No se encontró el registro");

            await Repository.DeleteAsync(id);

            response.Success = true;
        }
        catch (Exception ex)
        {
            response.ErrorMessage = $"Error al Eliminar {typeof(TEntity).Name}";
            Logger.LogError(ex, "{ResponseMessage} {Message}", response.ErrorMessage, ex.Message);
        }

        return response;
    }
}