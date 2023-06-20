using Microsoft.AspNetCore.Mvc;
using ShoeFactory.Dto.Request;
using ShoeFactory.Infraestructure.Interfaces;

namespace ShoeFactory.BackendApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _service;

    public CategoriesController(ICategoryService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get(string? filter)
    {
        var response = await _service.ListAsync(filter);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var response = await _service.GetAsync(id);

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Post(TableTypeDtoRequest request)
    {
        var response = await _service.AddAsync(request);

        return Ok(response);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, TableTypeDtoRequest request)
    {
        var response = await _service.UpdateAsync(id, request);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var response = await _service.DeleteAsync(id);

        return Ok(response);
    }
}