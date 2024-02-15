// See https://aka.ms/new-console-template for more information
Console.WriteLine("1850A To My Critics!");
Console.WriteLine("=======================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int[] inputs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    if (inputs[0] + inputs[1] >= 10 || inputs[0] + inputs[2] >= 10 || inputs[1] + inputs[2] >= 10)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }

}
