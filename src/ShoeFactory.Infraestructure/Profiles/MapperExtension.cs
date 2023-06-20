using AutoMapper;
using ShoeFactory.Dto.Request;
using ShoeFactory.Dto.Response;
using ShoeFactory.Entities;

namespace ShoeFactory.Infraestructure.Profiles;

public static class MapperExtension
{
    public static void AddTableTypeDto<TType>(
        this IMappingExpression<TType, TableTypeDtoResponse> configurationExpression)
        where TType : TableTypeBase
    {
        configurationExpression
            .ForMember(d => d.Codigo, o => o.MapFrom(_ => _.Code))
            .ForMember(d => d.Descripcion, o => o.MapFrom(_ => _.Description));
    }
    
    public static void FromTableTypeDto<TType>(
        this IMappingExpression<TableTypeDtoRequest, TType> configurationExpression)
        where TType : TableTypeBase
    {
        configurationExpression
            .ForMember(d => d.Code, o => o.MapFrom(_ => _.Code))
            .ForMember(d => d.Description, o => o.MapFrom(_ => _.Description));
    }
}