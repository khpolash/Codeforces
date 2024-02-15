// See https://aka.ms/new-console-template for more information
Console.WriteLine("1551A Polycarp and Coins!");
Console.WriteLine("===============================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);

    int c2 = n / 3;
    int c1 = n - c2 * 2;

    Console.WriteLine($"{c1} {c2}");
}