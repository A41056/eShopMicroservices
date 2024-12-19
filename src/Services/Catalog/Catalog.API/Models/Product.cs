namespace Catalog.API.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool IsDeleted { get; set; }
    public List<string> Category { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
}