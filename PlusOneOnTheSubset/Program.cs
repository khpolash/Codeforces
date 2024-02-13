// See https://aka.ms/new-console-template for more information
Console.WriteLine("1624A\tPlus One on the Subset!");
Console.WriteLine("=================================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] arr = new int[n];
    string[] str = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        arr[j] = int.Parse(str[j]);
    }

    int minValue = arr.Min();
    int maxValue = arr.Max();
    Console.WriteLine(maxValue - minValue);
}
