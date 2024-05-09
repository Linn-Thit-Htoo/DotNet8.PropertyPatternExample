namespace DotNet8.PropertyPatternExample;

public class Program
{
    public static void Main(string[] args)
    {
        Product product = new(1, "Product", 10000);

        if (product is { Price: > 1000, ProductName: "Product" })
        {
            EditProduct();
        }

        //Console.WriteLine(nameof(EnumGender.Male));
    }

    public static void EditProduct(Product? product = null)
    {
        if (product is { ProductId: 0 }) // product is not null and product id is not 0
        {
            return;
        }

        throw new Exception("Product ID cannot be empty.");
    }
}

public record Product(long ProductId, string ProductName, int Price);

public enum EnumGender
{
    None,
    Male,
    Female
}