namespace eShopping.Inventory.UseCases.UpdateProduct;

public class OrderItemDto
{
    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public bool IsIncreaseQuantity { get; set; }
}
