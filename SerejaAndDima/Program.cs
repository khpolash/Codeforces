// See https://aka.ms/new-console-template for more information
Console.WriteLine("381A\tSereja and Dima");
Console.WriteLine("=========================\n");

int n = int.Parse(Console.ReadLine()!);

int[] cards = new int[n];

string[] inputs = Console.ReadLine()!.Split();

int SerejaTotalCard = 0;
int DimaTotalCard = 0;

int turn = 0;

for (int i = 0; i < cards.Length; i++)
{
    cards[i] = int.Parse(inputs[i]);
}

while (cards.Length > 0)
{
    if (turn % 2 == 0)
    {
        if (cards[0] > cards[^1])
        {
            SerejaTotalCard += cards[0];
            cards = cards.Skip(1).ToArray();
        }
        else
        {
            SerejaTotalCard += cards[^1];
            cards = cards.SkipLast(1).ToArray();
        }
        turn++;
    }
    else
    {
        if (cards[0] > cards[^1])
        {
            DimaTotalCard += cards[0];
            cards = cards.Skip(1).ToArray();
        }
        else
        {
            DimaTotalCard += cards[^1];
            cards = cards.SkipLast(1).ToArray();
        }
        turn++;
    }

}

Console.WriteLine($"{SerejaTotalCard} {DimaTotalCard}");