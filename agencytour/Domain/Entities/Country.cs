namespace agencytour.Domain.Entities;

public class Country: BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public int Price { get; set; }
}