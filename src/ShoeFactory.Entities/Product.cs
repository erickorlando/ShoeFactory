namespace ShoeFactory.Entities;

public class Product : EntityBase
{
    public Category Category { get; set; } = default!;
    public int CategoryId { get; set; }
    public string Description { get; set; } = default!;
    public string Code { get; set; } = default!;
    public double MinimalStock { get; set; }
    public double MaximumStock { get; set; }
    public bool Active { get; set; }
}