// See https://aka.ms/new-console-template for more information

Console.WriteLine("1520A Do Not Be Distracted!");
Console.WriteLine("====================================\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string tasks = Console.ReadLine()!;

    bool suspicious = IsTeacherSuspicious(n, tasks);

    Console.WriteLine(suspicious ? "NO" : "YES");
}

static bool IsTeacherSuspicious(int n, string tasks)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (tasks[i] != tasks[i + 1])
        {
            for (int j = i + 2; j < n; j++)
            {
                if (tasks[j] == tasks[i])
                {
                    return true;
                }
            }
        }
    }
    return false;
}