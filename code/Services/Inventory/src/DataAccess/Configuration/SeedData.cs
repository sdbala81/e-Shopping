using eShopping.Inventory.Domain;

namespace eShopping.Inventory.DataAccess.Configuration;

public class SeedData
{
    // 1eae3b54-8ed5-4b52-bd6a-f6f078d73ed7
    // fca2dbfc-7e5c-4d5f-9c2e-926c6c2de2bb
    // e9a6aa9f-376a-4f0d-ae5d-0d5c1e31c4ed
    // d25c7a45-83a3-4a23-9c4e-3b0be30b3ad7
    // bc5e6e68-0ea5-4885-b86a-f1179c7cfd04
    // 0f9f118b-8d41-4ee0-a294-5cbcfb6f61c1
    // 7f2a37e4-40d9-4c82-89b1-68dc5e19a0c6
    // e4d138a1-9f4c-42a3-86f7-6c5bb6e871f9
    // 3fc6b8d7-5820-4e65-9c0f-2b7d0d3e6a35
    // a7892f96-297a-4a82-8c2e-1c78d21a5aeb
    // d06a9d0b-7fcd-4931-97d9-0c18ea0ef9bf
    // f5628703-8f6f-4edf-9683-91ea9c44b5fc
    // 4bd2e6d9-9c69-4c4a-b1c9-07bf4f335f52
    // 88a870e5-0b3e-4311-ae97-2091a5c34359
    // 6e33d8df-793f-4f60-9d2d-8e0ac731fddc
    // bff5b892-23e9-497d-b29a-85a3d4d228e6

    public static List<Product> Products()
    {
        var products = new List<Product>
        {
            new()
            {
                Id = Guid.Parse("1eae3b54-8ed5-4b52-bd6a-f6f078d73ed7"),
                Name = "Apple",
                CategoryId = 1,
                Quantity = 100,
                Price = 1.89
            },
            new()
            {
                Id = Guid.Parse("fca2dbfc-7e5c-4d5f-9c2e-926c6c2de2bb"),
                Name = "Orange",
                CategoryId = 1,
                Quantity = 100,
                Price = 2.59
            },
            new()
            {
                Id = Guid.Parse("e9a6aa9f-376a-4f0d-ae5d-0d5c1e31c4ed"),
                Name = "Banana",
                CategoryId = 1,
                Quantity = 100,
                Price = 1.58
            },
            new()
            {
                Id = Guid.Parse("d25c7a45-83a3-4a23-9c4e-3b0be30b3ad7"),
                Name = "Tomato",
                CategoryId = 2,
                Quantity = 100,
                Price = 1.99
            },
            new()
            {
                Id = Guid.Parse("bc5e6e68-0ea5-4885-b86a-f1179c7cfd04"),
                Name = "Potato",
                CategoryId = 2,
                Quantity = 100,
                Price = 1.29
            },
            new()
            {
                Id = Guid.Parse("0f9f118b-8d41-4ee0-a294-5cbcfb6f61c1"),
                Name = "Onion",
                CategoryId = 2,
                Quantity = 100,
                Price = 1.39
            },
            new()
            {
                Id = Guid.Parse("7f2a37e4-40d9-4c82-89b1-68dc5e19a0c6"),
                Name = "Laptop",
                CategoryId = 3,
                Quantity = 100,
                Price = 1000
            },
            new()
            {
                Id = Guid.Parse("e4d138a1-9f4c-42a3-86f7-6c5bb6e871f9"),
                Name = "Desktop",
                CategoryId = 3,
                Quantity = 100,
                Price = 1500
            },
            new()
            {
                Id = Guid.Parse("3fc6b8d7-5820-4e65-9c0f-2b7d0d3e6a35"),
                Name = "Keyboard",
                CategoryId = 3,
                Quantity = 100,
                Price = 50
            },
            new()
            {
                Id = Guid.Parse("a7892f96-297a-4a82-8c2e-1c78d21a5aeb"),
                Name = "Mouse",
                CategoryId = 3,
                Quantity = 100,
                Price = 25
            },
            new()
            {
                Id = Guid.Parse("d06a9d0b-7fcd-4931-97d9-0c18ea0ef9bf"),
                Name = "Rice",
                CategoryId = 4,
                Quantity = 100,
                Price = 10
            },
            new()
            {
                Id = Guid.Parse("f5628703-8f6f-4edf-9683-91ea9c44b5fc"),
                Name = "Wheat",
                CategoryId = 4,
                Quantity = 100,
                Price = 5.69
            },
            new()
            {
                Id = Guid.Parse("4bd2e6d9-9c69-4c4a-b1c9-07bf4f335f52"),
                Name = "Sugar",
                CategoryId = 4,
                Quantity = 100,
                Price = 2.99
            },
            new()
            {
                Id = Guid.Parse("88a870e5-0b3e-4311-ae97-2091a5c34359"),
                Name = "Salt",
                CategoryId = 4,
                Quantity = 100,
                Price = 1.99
            },
            new()
            {
                Id = Guid.Parse("6e33d8df-793f-4f60-9d2d-8e0ac731fddc"),
                Name = "Fish",
                CategoryId = 5,
                Quantity = 100,
                Price = 5.99
            },
            new()
            {
                Id = Guid.Parse("bff5b892-23e9-497d-b29a-85a3d4d228e6"),
                Name = "Shrimp",
                CategoryId = 5,
                Quantity = 100,
                Price = 4.56
            }
        };

        return products;
    }

    public static List<ProductCategory> ProductsAndCategories()
    {
        var productCategories = new List<ProductCategory>
        {
            new()
            {
                Id = 1,
                Name = "Fruits"
            },
            new()
            {
                Id = 2,
                Name = "Vegetables"
            },
            new()
            {
                Id = 3,
                Name = "Electronics"
            },
            new()
            {
                Id = 4,
                Name = "Groceries"
            },
            new()
            {
                Id = 5,
                Name = "Seafood"
            }
        };

        return productCategories;
    }
}
