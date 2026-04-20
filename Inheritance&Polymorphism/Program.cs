using Inheritance_Polymorphism;

Console.Write("Enter the number of products: ");
int num = int.Parse(Console.ReadLine());

List<Product> products = new();



for (int i = 1; i <= num; i++)
{
    System.Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, used or imported? (c, u or i) ");
    char type = char.Parse(Console.ReadLine());

    System.Console.Write("Enter product name: ");
    string name = Console.ReadLine();
    System.Console.Write("Enter product price: ");
    double price = double.Parse(Console.ReadLine());

    if (type == 'c'){
        products.Add(new Product(name, price));
    }
    else if (type == 'u')
    {
        Console.Write("Enter manufacture Date: ");
        DateOnly manufactureDate = DateOnly.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name, price, manufactureDate));
    }
    else
    {
        Console.Write("Enter customs fee: ");
        double fee = double.Parse(Console.ReadLine());
        products.Add(new ImportedProduct(name, price, fee));
    }

}


foreach (Product prod in products)
    {
        Console.WriteLine(prod.PriceTag());
    }