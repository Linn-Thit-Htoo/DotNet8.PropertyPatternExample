namespace DotNet8.PropertyPatternExample;

public class Program
{
    public static void Main(string[] args)
    {
        Product product = new(1, "Product", 10000);

        if (product is { Price: > 1000, ProductName: "Product" })
        {

        }
    }
}

//public class Product
//{
//    public Product(long productId, string productName, int price)
//    {
//        ProductId = productId;
//        ProductName = productName;
//        Price = price;
//    }

//    public long ProductId { get; set; }
//    public string ProductName { get; set; } = null!;
//    public int Price { get; set; }
//}

public record Product(long ProductId, string ProductName, int Price);