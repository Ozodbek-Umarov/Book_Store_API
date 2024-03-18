using Application.DTOs.AuthorDTOs;
using Application.DTOs.JanrDtos;

namespace Application.DTOs.BookDTOs;

public class UpdateBookDto: AddBookDto
{
    public int Id { get; set; }
    public List<AuthorDto> Authors { get; set; }
    public List<JanrDto> Janrs { get; set; }
}
