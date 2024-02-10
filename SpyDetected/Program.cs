// See https://aka.ms/new-console-template for more information
Console.WriteLine("1512A\tSpy Detected!");
Console.WriteLine("=====================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    int uniqueElement = numbers.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key).First();
    int index = Array.IndexOf(numbers, uniqueElement) + 1;

    Console.WriteLine(index);
}