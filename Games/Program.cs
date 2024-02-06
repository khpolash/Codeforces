
int n = int.Parse(Console.ReadLine()!);

int[,] teams = new int[n, 2];
for (int i = 0; i < n; i++)
{
    string[] colors = Console.ReadLine()!.Split();
    teams[i, 0] = int.Parse(colors[0]);
    teams[i, 1] = int.Parse(colors[1]);
}
int count = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i != j && teams[i, 0] == teams[j, 1])
        {
            count++;
        }
    }
}
Console.WriteLine(count);

