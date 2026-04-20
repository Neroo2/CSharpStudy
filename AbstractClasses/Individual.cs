using System;

namespace AbstractClasses;

public class Individual : TaxPayer
{

    public double HealthExpenditures { get; set; }

    public Individual(double health, string name, double income) : base(name, income)
    {
        HealthExpenditures = health;
    }

    public override double Tax()
    {
        if (AnualIncome < 200000)
        {
            return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
        }
        else
        {
            return (AnualIncome * 0.5) - (HealthExpenditures * 0.5);
        }
    }

}
