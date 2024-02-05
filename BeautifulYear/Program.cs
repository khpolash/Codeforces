int year = int.Parse(Console.ReadLine()!);
int nextYear = year + 1;
while (!IsDistinct(nextYear))
{
    nextYear++;
}

Console.WriteLine(nextYear);

static bool IsDistinct(int number)
{
    int[] digitArray = number.ToString().Select(c => int.Parse(c.ToString())).ToArray();
    HashSet<int> result = new(digitArray);
    return (result.Count == digitArray.Length);
}
