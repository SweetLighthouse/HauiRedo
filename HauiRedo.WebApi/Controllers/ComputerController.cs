using AutoMapper;
using HauiRedo.Application.Dtos.ComputerDto;
using HauiRedo.Application.Services.Interfaces;
using HauiRedo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HauiRedo.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ComputerController : ControllerBase
{
    private readonly IComputerService _service;
    private readonly IMapper _mapper;

    public ComputerController(IComputerService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetComputerByIdAsync([FromRoute] Guid id)
    {
        Computer? item = await _service.GetComputerByIdAsync(id);
        if (item == null) return NotFound();
        var responseItem = _mapper.Map<DetailComputerDto>(item);
        return Ok(responseItem);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllComputersAsync()
    {
        IEnumerable<Computer> items = await _service.GetAllComputersAsync();
        var responseItems = _mapper.Map<IEnumerable<ComputerDto>>(items);
        return Ok(responseItems);
    }

    [HttpPost]
    public async Task<IActionResult> AddComputerAsync([FromBody] ComputerDto itemDto)
    {
        var item = _mapper.Map<Computer>(itemDto);
        await _service.AddComputerAsync(item);
        return Created();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateComputerAsync([FromRoute] Guid id, [FromBody] ComputerDto itemDto)
    {
        Computer? item = await _service.GetComputerByIdAsync(id);
        if (item == null) return NotFound();
        Computer newItem = _mapper.Map<Computer>(itemDto);
        await _service.UpdateComputerAsync(newItem);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteComputerAsync([FromRoute] Guid id)
    {
        Computer? item = await _service.GetComputerByIdAsync(id);
        if (item == null) return NotFound();
        await _service.DeleteComputerAsync(id);
        return NoContent();
    }
}
