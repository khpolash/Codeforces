int totalPlay = int.Parse(Console.ReadLine()!);

string input = Console.ReadLine()!.ToUpper();

int gameOwnA = 0;
int gameOwnD = 0;

for (int i = 0; i < totalPlay; i++)
{
    if (input[i] == 'A')
    {
        gameOwnA++;
    }
    else if (input[i] == 'D')
    {
        gameOwnD++;
    }
}

Console.WriteLine((gameOwnA > gameOwnD) ? "Anton" : (gameOwnD > gameOwnA) ? "Danik" : "Friendship");
