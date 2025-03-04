namespace HauiRedo.Domain.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public Guid CreateId { get; set; }
    public DateTime CreateTime { get; set; }
    public Guid UpdateId { get; set; }
    public DateTime UpdateTime { get; set; }
}
