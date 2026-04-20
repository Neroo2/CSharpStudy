using Interfaces.Entities;
using Interfaces.Services;

System.Console.WriteLine("Enter contract data");

Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Date: ");
DateTime date = DateTime.Parse(Console.ReadLine());

Console.Write("Contract value: ");
double amount = double.Parse(Console.ReadLine());

Console.Write("Number of installments: ");
int numberInstallments = int.Parse(Console.ReadLine());

Contract contract = new(number, date, amount);

ContractService contractService= new(new PayPalService());

contractService.ProcessContract(contract, numberInstallments);

foreach (Installment installment in contract.Installments)
{
    Console.WriteLine($"{installment.DueDate} -- {installment.Amount}");
}