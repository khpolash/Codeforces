// See https://aka.ms/new-console-template for more information
Console.WriteLine("1551A Polycarp and Coins!");
Console.WriteLine("===============================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    double n = double.Parse(Console.ReadLine()!);

    double c1 = Math.Ceiling(n / 3);
    double c2 = Math.Floor((n - c1) / 2);

    if (c1 + 2 * c2 == n)
    {
        Console.WriteLine($"{c1} {c2}");
    }
    else
    {
        Console.WriteLine($"{c2} {c1}");
    }


}