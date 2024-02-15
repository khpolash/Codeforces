// See https://aka.ms/new-console-template for more information

Console.WriteLine("1370A Maximum GCD!");
Console.WriteLine("=========================\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int result = MaximumValueOfGCD(n);
    Console.WriteLine(result);
}

static int MaximumValueOfGCD(int n)
{
    return n / 2;
}