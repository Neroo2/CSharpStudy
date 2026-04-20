using System.Globalization;
using Enum_Composition.Entities;
using Enum_Composition.Entities.Enums;

Console.WriteLine("Enter client data: ");
Console.WriteLine("Name: ");
string name = Console.ReadLine();
Console.WriteLine("Email: ");
string email = Console.ReadLine();
Console.WriteLine("BirthDate - DD/MM/YYYY: ");
DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
Client client = new(name, email, birthDate);



Console.WriteLine("Enter order data: ");
Console.WriteLine("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.WriteLine("How many order items? ");
int num = int.Parse(Console.ReadLine());

Order order = new(DateTime.Now, status, client );



for (int i =1; i <= num; i++)
{
    Console.WriteLine($"Enter #{i} item data: ");
    Console.WriteLine($"Product Name: ");
    string prodName = Console.ReadLine();
    Console.WriteLine($"Product Price: ");
    double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine($"Product Quantity: ");
    int prodQuantity = int.Parse(Console.ReadLine());

    Product product = new(prodName,prodPrice);

    OrderItem orderItem = new(prodQuantity, prodPrice, product);
    
    order.addItem(orderItem);
}


Console.WriteLine(order);