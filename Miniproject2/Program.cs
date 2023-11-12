
// Initiera en tom lista för att lagra produkter

List<Product> items = new List<Product>();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("To enter a new product - follow the steps, to quit - enter: Q");
Console.ResetColor();

/* Inuti while-loopen uppmanas användaren att ange kategori,
 produktnamn och pris för varje produkt.*/
while (true)
{
    // Get Category (Lägg till kategorinamn)
    Console.Write("Input Category: ");
    string categoryInput = Console.ReadLine().Trim();
    if (categoryInput.ToLower().Trim() == "q")
    {
        break;
    }

    if (String.IsNullOrWhiteSpace(categoryInput))
    {
        Console.WriteLine("Add the Category");
        continue;
    }

    // Get Product Name (Lägg till produktnamn)
    Console.Write("Input Product: ");
    string productInput = Console.ReadLine();
    if (productInput.ToLower().Trim() == "q")
    {
       break;
    }
    if (String.IsNullOrWhiteSpace(productInput))
    {
       Console.WriteLine("Add Product Name");
       continue;
    }

    // Get Price (Tilläggspris)

    Console.Write("Input Price: ");
    string priceInput = Console.ReadLine();
    if (priceInput.ToLower().Trim() == "q")
    {
        break;
    }
    bool isValid = int.TryParse(priceInput, out int price);

    /* Om inmatningen är giltig skapas ett nytt produktobjekt
     som läggs till i artikellistan.*/

    if (isValid)
    {
        Product product = new Product(categoryInput, productInput, price);
        items.Add(product);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The product was added to list");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("The price should be a numeric value");
        Console.ResetColor();
    }
}

Console.WriteLine("All List");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price");
Console.ResetColor();

// Artikellistan sorteras efter pris med hjälp av LINQs OrderBy-metod

List<Product> sorteditems = items.OrderBy(item => item.Price).ToList();
foreach (var item in sorteditems)
{
    
    Console.WriteLine(item.Category.PadRight(20) + item.ProductName.PadRight(20) + item.Price);
    

}
/*  the total amount of all products is calculated using LINQ's Sum method
 and displayed below the list.*/

Console.WriteLine("".PadRight(20) + "Total amount:".PadRight(20) + items.Sum(prod => prod.Price));


class Product
{
    public Product(string category, string productName, int price)
    {
        Category = category;
        ProductName = productName;
        Price = price;
    }

    public string Category { get; set; }
    public string ProductName { get; set; }
    public int Price { get; set; }

}
