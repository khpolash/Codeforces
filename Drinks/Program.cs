int n = int.Parse(Console.ReadLine()!);
string[] input = Console.ReadLine()!.Split();

double sum = 0;

for (int i = 0; i < n; i++)
{
    sum += int.Parse(input[i]);
}
Console.WriteLine(sum / n);