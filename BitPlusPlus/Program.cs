int testCase = int.Parse(Console.ReadLine()!);

int result = 0;

for (int i = 0; i < testCase; i++)
{
    string input = Console.ReadLine()!;
    if (input.Contains("++"))
    {
        result++;
    }
    else
    {
        result--;
    }
}
Console.WriteLine(result);