// See https://aka.ms/new-console-template for more information
Console.WriteLine("1669A\tDivision");
Console.WriteLine("===============\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int rating = int.Parse(Console.ReadLine()!);

    switch (rating)
    {
        case >= 1900:
            Console.WriteLine($"Division 1");
            break;
        case >= 1600 and <= 1899:
            Console.WriteLine($"Division 2");
            break;
        case >= 1400 and <= 1599:
            Console.WriteLine($"Division 3");
            break;
        default:
            Console.WriteLine($"Division 4");
            break;
    }
}
