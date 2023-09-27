namespace eShopping.Inventory.Domain;

public class ProductCategory : BaseEntity<byte>
{
    public string Name { get; set; }

    public List<Product> Products { get; set; }
}
