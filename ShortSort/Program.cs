// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("1873A Short Sort!\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string cards = Console.ReadLine()!;
    string target = new(cards.OrderBy(x => x).ToArray());
    int wrongPosition = 0;

    for (int j = 0; j < cards.Length; j++)
    {
        if (target[j] != cards[j])
        {
            wrongPosition++;
        }
    }

    Console.WriteLine(wrongPosition > 2 ? "NO" : "YES");

}
