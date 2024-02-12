// See https://aka.ms/new-console-template for more information
Console.WriteLine("1807A Plus or Minus!");
Console.WriteLine("========================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    if (numbers[0] + numbers[1] == numbers[2])
    {
        Console.WriteLine("+");
    }
    else if (numbers[0] - numbers[1] == numbers[2])
    {
        Console.WriteLine("-");
    }
}