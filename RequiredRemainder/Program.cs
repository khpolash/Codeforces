// See https://aka.ms/new-console-template for more information
Console.WriteLine("1374A\tRequired Remainder!");
Console.WriteLine("=============================\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    long x = int.Parse(inputs[0]);
    long y = int.Parse(inputs[1]);
    long n = int.Parse(inputs[2]);

    double k = n - (n % x) + y;

    Console.WriteLine(k > n ? (n - n % x - (x - y)) : k);
}



