namespace Domain.Entities;

public class Janr : BaseEntity
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}
