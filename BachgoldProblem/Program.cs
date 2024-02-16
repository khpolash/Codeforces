// See https://aka.ms/new-console-template for more information
Console.WriteLine("749A Bachgold Problem!");
Console.WriteLine("=============================\n");

int t = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{(t % 2 == 0 ? t / 2 : (t - 3) / 2 + 1)}\n{DisplayAllPrimeNumbers(t)}");

static string DisplayAllPrimeNumbers(int n)
{
    return (n % 2 == 0)
        ? string.Join(" ", new string[n / 2].Select(_ => "2"))
        : $"{string.Join(" ", new string[(n - 3) / 2].Select(_ => "2"))} 3";
}