namespace eShopping.Inventory.Domain;

public class Product : BaseEntity<Guid>
{
    public string Name { get; set; }

    public int Quantity { get; set; }

    public ProductCategory Category { get; set; }

    public byte CategoryId { get; set; }

    public double Price { get; set; }
}
