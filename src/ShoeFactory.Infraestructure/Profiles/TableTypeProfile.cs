using AutoMapper;
using ShoeFactory.Dto.Request;
using ShoeFactory.Dto.Response;
using ShoeFactory.Entities;

namespace ShoeFactory.Infraestructure.Profiles;

public class TableTypeProfile : Profile
{
    public TableTypeProfile()
    {
        CreateMap<Category, TableTypeDtoResponse>().AddTableTypeDto();
        CreateMap<TableTypeDtoRequest, Category>().FromTableTypeDto();

        CreateMap<Currency, TableTypeDtoResponse>().AddTableTypeDto();
        CreateMap<TableTypeDtoRequest, Currency>().FromTableTypeDto();

        CreateMap<Leather, TableTypeDtoResponse>().AddTableTypeDto();
        CreateMap<TableTypeDtoRequest, Leather>().FromTableTypeDto();
        
        CreateMap<Model, TableTypeDtoResponse>().AddTableTypeDto();
        CreateMap<TableTypeDtoRequest, Model>().FromTableTypeDto();
        
        CreateMap<Movement, TableTypeDtoResponse>().AddTableTypeDto();
        CreateMap<TableTypeDtoRequest, Movement>().FromTableTypeDto();
        
        CreateMap<PaymentType, TableTypeDtoResponse>().AddTableTypeDto();
        CreateMap<TableTypeDtoRequest, PaymentType>().FromTableTypeDto();
        
        CreateMap<SectionCode, TableTypeDtoResponse>().AddTableTypeDto();
        CreateMap<TableTypeDtoRequest, SectionCode>().FromTableTypeDto();
    }
}