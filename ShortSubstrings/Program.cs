// See https://aka.ms/new-console-template for more information

Console.WriteLine("1367A\tShort Substrings");
Console.WriteLine("==========================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string b = Console.ReadLine()!;
    string result = GuessStringA(b);
    Console.WriteLine(result);
}

static string GuessStringA(string b)
{
    int n = b.Length;
    string a = b[..1];

    for (int i = 1; i < n; i += 2)
    {
        a += b[i];
    }

    return a;
}