using System;

namespace AbstractClasses;

public abstract class TaxPayer
{
    public string Name { get; set; }
    public double AnualIncome { get; set; }

    public TaxPayer(string name, double income)
    {
        Name = name;
        AnualIncome = income;
    }

    public abstract double Tax();
    
}
