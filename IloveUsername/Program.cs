int testCase = int.Parse(Console.ReadLine()!);

string[] pointsString = Console.ReadLine()!.Split();

int[] points = new int[testCase];

for (int i = 0; i < testCase; i++)
{
    points[i] = int.Parse(pointsString[i]);
}
int bestPerformance = points[0];
int worstPerformance = points[0];
int amazingPerformances = 0;

for (int i = 0; i < points.Length; i++)
{
    if (points[i] > bestPerformance)
    {
        bestPerformance = points[i];
        amazingPerformances++;
    }
    else if (points[i] < worstPerformance)
    {
        worstPerformance = points[i];
        amazingPerformances++;
    }
}

Console.WriteLine(amazingPerformances);