using Application.DTOs.AuthorDTOs;
using Application.DTOs.JanrDtos;

namespace Application.DTOs.BookDTOs;

public class AddBookDto
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public double Price { get; set; }
    public int JanrId { get; set; }
    public List<JanrDto> Janrs { get; set; } = new();
    public int AuthorId { get; set; }
    public List<AuthorDto> Authors { get; set; } = new();
}
