namespace Domain.Entities;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public string Price { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public int JanrId { get; set; } 
    public Janr Janr { get; set; }
}
