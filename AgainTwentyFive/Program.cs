// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Codeforce Problem NO: 630A Again Twenty Five!");
Console.WriteLine("==================================\n");


long n = long.Parse(Console.ReadLine()!);

long result = PowerModulo(5, n, 100);

Console.WriteLine(result.ToString("D2"));
static long PowerModulo(long baseNum, long exponent, long modulo)
{
    if (exponent == 0)
        return 1;

    long result = 1;
    baseNum %= modulo;

    while (exponent > 0)
    {
        if (exponent % 2 == 1)
            result = (result * baseNum) % modulo;

        exponent >>= 1;
        baseNum = (baseNum * baseNum) % modulo;
    }

    return result;
}