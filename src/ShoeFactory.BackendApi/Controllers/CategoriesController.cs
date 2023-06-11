using Microsoft.AspNetCore.Mvc;
using ShoeFactory.Infraestructure.Interfaces;

namespace ShoeFactory.BackendApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ITableTypeService _service;

    public CategoriesController(ITableTypeService service)
    {
        _service = service;
    }
}