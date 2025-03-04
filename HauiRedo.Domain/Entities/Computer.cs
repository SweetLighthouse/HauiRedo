namespace HauiRedo.Domain.Entities;

public class Computer : BaseEntity
{
    public string? Name { get; set; }
    public int Ram { get; set; }
    public double Storage { get; set; }
    public string? Note { get; set; }
}
