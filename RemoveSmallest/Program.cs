

int testCase = int.Parse(Console.ReadLine()!);

for (int i = 0; i < testCase; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] inputs = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

    string result = IsPossibleToOneElement(n, inputs) ? "YES" : "NO";
    Console.WriteLine(result);
}

static bool IsPossibleToOneElement(int n, int[] a)
{
    bool flag = true;
    int[] distinctElements = a.Distinct().ToArray();
    Array.Sort(distinctElements);

    for (int i = 1; i < distinctElements.Length; i++)
    {
        if (distinctElements[i] - distinctElements[i - 1] > 1)
        {
            flag = false;
            break;
        }
    }

    return flag;
}