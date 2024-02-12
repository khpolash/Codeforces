// See https://aka.ms/new-console-template for more information
Console.WriteLine("1343B\tBalanced Array");
Console.WriteLine("=======================\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    long n = long.Parse(Console.ReadLine()!);
    if (n % 4 != 0)
    {
        Console.WriteLine("NO");

    }
    else
    {

        Console.WriteLine("YES");
        Console.WriteLine(string.Join(" ", ConstructArray(n)));
    }
}

static long[] ConstructArray(long n)
{
    long[] evenNumbers = new long[n / 2];
    long[] oddNumbers = new long[n / 2];

    for (int i = 0; i < n / 2; i++)
    {
        evenNumbers[i] = 2 * (i + 1);
        oddNumbers[i] = 2 * i + 1;
    }

    long evenSum = evenNumbers.Sum();
    long oddSum = oddNumbers.Sum();

    while (evenSum != oddSum)
    {
        oddNumbers[^1] = oddNumbers[^1] + 2;
        oddSum += 2;
    }

    long[] resultArray = new long[n];
    Array.Copy(evenNumbers, resultArray, n / 2);
    Array.Copy(oddNumbers, 0, resultArray, n / 2, n / 2);

    return resultArray;
}