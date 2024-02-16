// See https://aka.ms/new-console-template for more information
Console.WriteLine("1280A Minutes Before the New Year!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int[] inputs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    int remainingMinutes = (24 * 60) - ((inputs[0] * 60) + inputs[1]);

    Console.WriteLine(remainingMinutes);
}
