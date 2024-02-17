// See https://aka.ms/new-console-template for more information

Console.WriteLine("1426A Floor Number!");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine()!.Split();
    int n = int.Parse(input[0]);
    int x = int.Parse(input[1]);

    int result = PetyaApartmentNumber(n, x);
    Console.WriteLine(result);
}

static int PetyaApartmentNumber(int n, int x)
{
    return (n <= 2) ? 1 : (int)Math.Floor((decimal)((n - 3) / x) + 2);
}