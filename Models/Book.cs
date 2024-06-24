namespace Models;

public class Book 
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int NumberOfPages { get; set; }
    public DateTime PublishDate { get; set; }
}