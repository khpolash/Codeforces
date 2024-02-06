
int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int x = int.Parse(Console.ReadLine()!);
    Console.WriteLine((x % 2 != 0) ? ((x - 1) / 2) : ((x / 2) - 1));
}