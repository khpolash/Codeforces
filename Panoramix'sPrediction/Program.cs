// See https://aka.ms/new-console-template for more information
Console.WriteLine("8-0A Panoramix's Prediction!");
Console.WriteLine("=================================\n");

int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int firstPrime = input[0];
int nextPrime = FindNextPrime(firstPrime);
Console.WriteLine(nextPrime == input[1] ? "YES" : "NO");

static int FindNextPrime(int start)
{
    int next = start + 1;
    while (true)
    {
        if (IsPrime(next))
            return next;

        next++;
    }
}

static bool IsPrime(int n)
{
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}