// See https://aka.ms/new-console-template for more information
Console.WriteLine("1692A Marathon");
Console.WriteLine("===============\n");

int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    int[] inputs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int count = 0;

    if (inputs[1] > inputs[0])
        count++;
    if (inputs[2] > inputs[0])
        count++;
    if (inputs[3] > inputs[0])
        count++;

    Console.WriteLine(count);
}
