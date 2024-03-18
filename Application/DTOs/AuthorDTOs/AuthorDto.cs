using Domain.Entities;

namespace Application.DTOs.AuthorDTOs;

public class AuthorDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string ImagePath { get; set; } = null!;
    public static implicit operator AuthorDto(Author author)
        => new()
        {
            Id = author.Id,
            FullName = author.FullName,
            ImagePath = author.ImageUrl
        };
}
