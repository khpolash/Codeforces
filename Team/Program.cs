int n = int.Parse(Console.ReadLine()!);

int count = 0;

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()!.Split();
    int sureCount = 0;
    for (int j = 0; j < 3; j++)
    {
        if (input[j] == "1")
        {
            sureCount++;
        }
    }
    if (sureCount >= 2)
    {
        count++;
    }
}