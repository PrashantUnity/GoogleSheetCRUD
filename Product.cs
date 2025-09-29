public class Product : IEntityWithId
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Category { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
    public DateTime CreatedDate { get; set; }
    public bool IsActive { get; set; }
}
