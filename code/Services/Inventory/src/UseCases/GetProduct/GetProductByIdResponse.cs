namespace eShopping.Inventory.UseCases.GetProduct;

public class GetProductByIdResponse
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Category { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }
}
