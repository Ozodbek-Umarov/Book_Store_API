using Application.DTOs.AuthorDTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorController(IAuthorService authorService)
    : ControllerBase
{
    private readonly IAuthorService _authorService = authorService;

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _authorService.GetAllAsync();
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> AddAsync(AddAuthorDto dto)
    {
        await _authorService.AddAsync(dto);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        await _authorService.DeleteAsync(id);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var result = await _authorService.GetByIdAsync(id);
        return Ok(result);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(AuthorDto dto)
    {
        await _authorService.UpdateAsync(dto);
        return Ok();
    }

}
