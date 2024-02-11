// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("472A\tDesign Tutorial: Learn from Math");
Console.WriteLine("=======================================\n");

int n = int.Parse(Console.ReadLine()!);

int x = 4;
int y = n - x;

while (n > 0)
{
    if ((!IsPrime(x) && !IsPrime(y) && x + y == n))
    {
        Console.WriteLine($"{x} {y}");
        break;
    }
    x++;
    y = n - x;
}

static bool IsPrime(int number)
{
    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}