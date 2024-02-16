// See https://aka.ms/new-console-template for more information
Console.WriteLine("1535A Fair Playoff!\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    if (Math.Min(input[0], input[1]) > Math.Max(input[2], input[3]) || Math.Max(input[0], input[1]) < Math.Min(input[2], input[3]))
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }

}

