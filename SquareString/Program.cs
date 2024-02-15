// See https://aka.ms/new-console-template for more information
Console.WriteLine("1619A Square String?");
Console.WriteLine("==========================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string inputs = Console.ReadLine()!;
    int len = inputs.Length;

    if (len % 2 == 0)
    {
        string one = inputs[..(len / 2)];
        string two = inputs[(len / 2)..];

        Console.WriteLine(one == two ? "YES" : "NO");
    }
    else
    {
        Console.WriteLine($"NO");
    }
}
