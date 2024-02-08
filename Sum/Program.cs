// See https://aka.ms/new-console-template for more information
Console.WriteLine("Codeforce Problem NO: 1742A Sum");
Console.WriteLine("==================================\t");

int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse).ToArray();
    Array.Sort(numbers);

    if (numbers[0] + numbers[0 + 1] == numbers[2])
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }

}

