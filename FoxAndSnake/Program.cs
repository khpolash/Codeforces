string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);
int count = 0;

if (n % 2 == 0)
{
    Console.WriteLine("n should be an odd number.");
    return;
}

char[,] result = new char[n, m];

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = '#';
        }
    }
    else
    {
        count++;
        for (int j = 0; (j < m); j++)
        {
            if (count % 2 == 1 && j == m - 1)
            {
                result[i, j] = '#';
            }
            else if (count % 2 == 0 && j == 0)
            {
                result[i, j] = '#';
            }
            else
            {
                result[i, j] = '.';
            }
        }
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(result[i, j]);
    }
    Console.WriteLine();
}
