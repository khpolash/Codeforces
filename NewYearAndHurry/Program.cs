string[] inputs = Console.ReadLine()!.Split();

int n = int.Parse(inputs[0]);
int k = int.Parse(inputs[1]);

int totalMinutes = 240 - k;
int solvedProblems = 0;
int timeRequired = 0;

for (int i = 1; i <= n; i++)
{
    timeRequired += 5 * i;
    if (timeRequired <= totalMinutes)
    {
        solvedProblems += 1;
    }
    else
    {
        break;
    }
}

Console.WriteLine(solvedProblems);