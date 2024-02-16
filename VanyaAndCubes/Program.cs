// See https://aka.ms/new-console-template for more information
Console.WriteLine("492A Vanya and Cubes!");
Console.WriteLine("==========================\n");

int cubes = int.Parse(Console.ReadLine()!);

int i = 1; int m = 1; int height = 0;

while (m <= cubes)
{
    m = ((i * i) + i) / 2;
    if (m > cubes)
    {
        break;
    }
    cubes -= m;
    height++;
    i++;
}
Console.WriteLine(height);