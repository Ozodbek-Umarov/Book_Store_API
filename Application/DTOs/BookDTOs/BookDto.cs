using Application.DTOs.AuthorDTOs;

namespace Application.DTOs.BookDTOs;

public class BookDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public JanrDto Janr { get; set; } = new();
    public AuthorDto Author { get; set; } = new();
    public string ImagePath { get; set; } = "";
}
