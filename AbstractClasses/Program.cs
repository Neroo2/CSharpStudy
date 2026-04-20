using System.Globalization;
using AbstractClasses;

System.Console.Write("Enter the number of tax payers: ");
int num = int.Parse(Console.ReadLine());
var taxPayers = new List<TaxPayer>();



for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"Tax payer #{i} data");
    Console.Write("Individual or company: (i/c) ");
    char option = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual Income: ");
    double income = double.Parse(Console.ReadLine());

    if (option == 'c')
    {
        Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());
        taxPayers.Add(new Company(name, income, employees));
    }
    else
    {
        Console.Write("Enter health expenditures: ");
        double health = double.Parse(Console.ReadLine());
        taxPayers.Add(new Individual(health, name, income));
    }
}


double sum = 0;

foreach(TaxPayer tP in taxPayers)
{

    Console.WriteLine ($"Name: { tP.Name} -- Taxes paid: {tP.Tax().ToString("F2", CultureInfo.InvariantCulture)} ");

    sum += tP.Tax();


}

Console.WriteLine($"Total Taxes: {sum.ToString()}");