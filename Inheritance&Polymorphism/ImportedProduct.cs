using System;
using System.Runtime.InteropServices.Marshalling;

namespace Inheritance_Polymorphism;

public class ImportedProduct : Product
{


    double CustomsFee {get; set;}

    public ImportedProduct (string name, double price, double customsFee) : base(name, price) {
        CustomsFee = customsFee;
    }


    public override string PriceTag()
    {
        return $"Imported: Name: {Name}, {Total()}, Fees: {CustomsFee}";
    }


    public double Total()
    {
        return Price + CustomsFee;
    }


}


