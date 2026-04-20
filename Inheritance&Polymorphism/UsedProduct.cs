using System;

namespace Inheritance_Polymorphism;

public class UsedProduct : Product
{
    DateOnly ManufactureDate {get; set;}


    public UsedProduct (string name, double price, DateOnly manufactureDate) : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }


    public override string PriceTag()
    {
        return "USED: " + base.PriceTag() + $" {ManufactureDate.ToString("dd/MM/yyyy")}";
    }


}
