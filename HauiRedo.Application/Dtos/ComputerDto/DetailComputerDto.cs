namespace HauiRedo.Application.Dtos.ComputerDto;

public class DetailComputerDto
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string? Name { get; set; }
    public int Ram { get; set; }
    public double Storage { get; set; }
    public string? Note { get; set; }
}
