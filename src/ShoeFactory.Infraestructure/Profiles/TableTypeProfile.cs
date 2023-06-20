using AutoMapper;
using ShoeFactory.Dto.Request;
using ShoeFactory.Dto.Response;
using ShoeFactory.Entities;

namespace ShoeFactory.Infraestructure.Profiles;

public class TableTypeProfile : Profile
{
    public TableTypeProfile()
    {
        CreateMap<Category, TableTypeDtoResponse>()
            .ForMember(d => d.Codigo, o => o.MapFrom(_ => _.Code))
            .ForMember(d => d.Descripcion, o => o.MapFrom(_ => _.Description));

        CreateMap<TableTypeDtoRequest, Category>();
    }
}