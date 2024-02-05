long n = long.Parse(Console.ReadLine()!);

Console.WriteLine(IsNearlyLucky(n) ? "YES" : "NO");

static bool IsNearlyLucky(long n)
{
    string numberString = n.ToString();
    int luckyDigitsCount = 0;

    foreach (char digit in numberString)
    {
        if (digit == '4' || digit == '7')
        {
            luckyDigitsCount++;
        }
    }

    return IsLucky(luckyDigitsCount);
}

static bool IsLucky(int x)
{
    return x == 4 || x == 7 || x == 44 || x == 47 || x == 74 || x == 77;
}
