using AutoMapper;
using Microsoft.Extensions.Logging;
using ShoeFactory.Entities;
using ShoeFactory.Infraestructure.Interfaces;
using ShoeFactory.Repositories.Interfaces;

namespace ShoeFactory.Infraestructure.Implementations;

public class CategoryService : TableTypeServiceBase<Category>, ICategoryService
{
    public CategoryService(
        ILogger<CategoryService> logger, 
        ICategoryRepository repository, 
        IMapper mapper) 
        : base(logger, repository, mapper)
    {

    }
}