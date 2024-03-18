namespace Domain.Entities;

public class User : BaseEntity
{
    public string FullName { get; set; }
    public string Password { get; set; }
    public string TelNomer { get; set; }
    public string Address { get; set; }
}
