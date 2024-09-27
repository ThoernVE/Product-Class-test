namespace Github_test;

/*
    Jag tror det saknas kommentarer
*/

//VARFÖR FINNS DET INGA KOMMENTARER?!?!?!? VAR ÄR PRICE?!!??!?!

// kommenterara???


class Product 
{
    public int Price;
    public string Name;
    public string Category; 
    public Product(int Price, string Name, string Category)
    {
        this.Price = Price;
        this.Name = Name;
        this.Category = Category;
    }
}


class Program
{
    static void AddProduct(int price, string name, string category, List<Product> list)
    {   
        Product product = new Product(price, name, category);
        list.Add(product);
    }

    static void PrintAvailableProducts(List<Product> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine($"Product: {product.Name}");
            Console.WriteLine($"Category: {product.Category}");
            Console.WriteLine($"Price: {product.Price}kr");
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("\n---------------------------\n");
        List<Product> products = new List<Product>();

        // Add some products
        AddProduct(99, "Kaffe", "Mat", products);
        AddProduct(59, "Mjölk", "Mat", products);
        AddProduct(499999999, "Airbus a380", "Flygplan", products);

        // Print all available products
        PrintAvailableProducts(products);
    }
}
