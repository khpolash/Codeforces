// See https://aka.ms/new-console-template for more information
Console.WriteLine("1360A Minimal Square!");
Console.WriteLine("=============================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int[] inputs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    int a = inputs[0];
    int b = inputs[1];

    int result = (Math.Min(Math.Max(2 * b, a), Math.Max(2 * a, b)));

    Console.WriteLine(Math.Pow(result, 2));
}
