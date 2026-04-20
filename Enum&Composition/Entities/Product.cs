using System;

namespace Enum_Composition.Entities;

public class Product
{
    public String Name { get; set; }
    public double Price { get; set; }


    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
