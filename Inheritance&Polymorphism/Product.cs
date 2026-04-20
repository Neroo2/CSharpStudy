using System;

namespace Inheritance_Polymorphism;

public class Product
{
    protected String Name {get; set;}
    protected Double Price {get; set;}



    public Product (string name, double price) {
        Name = name;
        Price = price;
    }


    public virtual string PriceTag()
    {
        return $"Name: {Name} -- Price: {Price}";
    }
}
