// See https://aka.ms/new-console-template for more information

Console.WriteLine("1433A Boring Apartments!");
Console.WriteLine("===========================\n");



int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string input = Console.ReadLine()!;
    Console.WriteLine(TotalDigitePressed(input));
}

static int TotalDigitePressed(string input)
{
    int digit = int.Parse(input[0].ToString()) - 1;
    int lenth = input.Length;

    return ((digit * 10) + ((lenth * (lenth + 1)) / 2));
}