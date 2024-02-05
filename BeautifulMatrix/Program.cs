int tergetRow = 3, tergetCol = 3;
int curentRow = 0, curentCol = 0;

int[,] mattrix = new int[5, 5];

for (int i = 0; i < 5; i++)
{
    string[] inoutRow = Console.ReadLine()!.Split();
    for (int j = 0; j < 5; j++)
    {
        mattrix[i, j] = int.Parse(inoutRow[j]);
        if (mattrix[i, j] == 1)
        {
            curentRow = i + 1;
            curentCol = j + 1;
        }
    }
}
int move = Math.Abs(curentRow - tergetRow) + Math.Abs(curentCol - tergetCol);

Console.WriteLine(move);