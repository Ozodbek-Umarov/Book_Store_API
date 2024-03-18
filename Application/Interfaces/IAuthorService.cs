using Application.DTOs.AuthorDTOs;

namespace Application.Interfaces;

public interface IAuthorService
{
    Task<List<AuthorDto>> GetAllAsync();
    Task<AuthorDto> GetByIdAsync(int id);
    Task AddAsync(AddAuthorDto dto);
    Task UpdateAsync(AuthorDto dto);
    Task DeleteAsync(int id);
}
