// See https://aka.ms/new-console-template for more information
Console.WriteLine("1676A\tLucky?");
Console.WriteLine("=================\n");

int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    string inputs = Console.ReadLine()!;

    string first = inputs[..^(inputs.Length / 2)];
    string second = inputs[(inputs.Length / 2)..];

    int sum1 = first.Sum(x => x);
    int sum2 = second.Sum(x => x);

    Console.WriteLine(sum1 == sum2 ? "YES" : "NO");
}
