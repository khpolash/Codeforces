// See https://aka.ms/new-console-template for more information
Console.WriteLine("1760A\tMedium Number!");
Console.WriteLine("=========================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int[] inputs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    Array.Sort(inputs);

    Console.WriteLine(inputs[1]);
}