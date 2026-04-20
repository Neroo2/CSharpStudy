using System;

namespace AbstractClasses;

public class Company: TaxPayer
{

    public int NumberEmployees { get; set; }


    public Company(string name, double income, int employees) : base (name, income)
    {
        NumberEmployees = employees;
    }



    public override double Tax()
    {
        if (NumberEmployees > 10)
        {
            return (AnualIncome * 0.14);
        }
        else
        {
            return (AnualIncome * 0.16);
        }
    }

}
