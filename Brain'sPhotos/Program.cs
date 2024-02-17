// See https://aka.ms/new-console-template for more information
Console.WriteLine("707A Brain's Photos!\n");

string[] n = Console.ReadLine()!.Split();

int rows = int.Parse(n[0]);
int cols = int.Parse(n[1]);

char[,] array = new char[rows, cols];

for (int i = 0; i < rows; i++)
{
    string[] inputs = Console.ReadLine()!.ToUpper().Split();
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = char.Parse(inputs[j]);
    }
}

bool result = array.Cast<char>().All(c => c == 'W' || c == 'B' || c == 'G');

Console.WriteLine(result ? "#Black&White" : "#Color");

