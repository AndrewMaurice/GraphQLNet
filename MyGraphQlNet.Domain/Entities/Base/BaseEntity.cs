namespace Entities.Base;

public class BaseEntity<TId>
{
    public TId Id { get; set; }
    public DateTimeOffset CreationDate { get; set; }
}