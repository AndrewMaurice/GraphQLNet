using Entities.Base;

namespace Entities;

public class Book : BaseEntity<Guid>
{
    public string Name { get; set; }
    public int NumberOfPages { get; set; }

    public Book(string Name, int NumberOfPages)
    {
        this.Name = Name;
        this.NumberOfPages = NumberOfPages;

        Id = Guid.NewGuid();
        CreationDate = DateTimeOffset.UtcNow;
    }
}