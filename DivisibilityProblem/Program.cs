int testCase = int.Parse(Console.ReadLine()!);

for (int i = 0; i < testCase; i++)
{
    string[] input = Console.ReadLine()!.Split();
    int n = int.Parse(input[0]);
    int m = int.Parse(input[1]);

    int result = CalculateMoves(n, m);
    Console.WriteLine(result);
}

static int CalculateMoves(int x, int y)
{
    return (x % y) == 0 ? 0 : (y - (x % y));
}