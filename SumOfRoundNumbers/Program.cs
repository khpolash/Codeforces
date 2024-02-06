int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    List<int> roundNumbers = SumOfRoundNumbers(n);

    Console.WriteLine(roundNumbers.Count);
    Console.WriteLine(string.Join(" ", roundNumbers));
}

static List<int> SumOfRoundNumbers(int n)
{
    List<int> result = new List<int>();
    string nStr = n.ToString();

    for (int i = 0; i < nStr.Length; i++)
    {
        int digit = int.Parse(nStr[i].ToString());
        if (digit != 0)
        {
            result.Add(digit * (int)Math.Pow(10, nStr.Length - i - 1));
        }
    }
    return result;
}