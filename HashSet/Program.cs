System.Console.Write("How many students for course A? ");
int courseA = int.Parse(Console.ReadLine());
System.Console.Write("How many students for course B? ");
int courseB = int.Parse(Console.ReadLine());
System.Console.Write("How many students for course C? ");
int courseC = int.Parse(Console.ReadLine());

HashSet<int> alunos = new();


for (int i = 1; i <= courseA; i++)
{
    Console.WriteLine("A: ");
    int number = int.Parse(Console.ReadLine());
    alunos.Add(number);

}

for (int i = 1; i <= courseB; i++)
{
    Console.WriteLine("B: ");
    int number = int.Parse(Console.ReadLine());
    alunos.Add(number);

}

for (int i = 1; i <= courseC; i++)
{
    Console.WriteLine("C: ");
    int number = int.Parse(Console.ReadLine());
    alunos.Add(number);

}

Console.WriteLine(alunos.Count);