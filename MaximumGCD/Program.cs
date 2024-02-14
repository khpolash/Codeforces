// See https://aka.ms/new-console-template for more information

Console.WriteLine("1370A Maximum GCD!");
Console.WriteLine("=========================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);

    int result = MaximumValueOfGCD(n);
    Console.WriteLine(result);
}

static int MaximumValueOfGCD(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        for (int j = i + 1; j <= n; j++)
        {
            int gcd = FindGCD(i, j);
            if (gcd > result)
            {
                result = gcd;
            }
        }

    }

    return result;
}

static int FindGCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}