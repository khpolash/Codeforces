string input = Console.ReadLine()!;
string lettersOnly = input[1..^1];

Console.WriteLine(CountDistinct(lettersOnly));

static int CountDistinct(string str)
{
    char[] digitArray = str.Where(ch => Char.IsLetter(ch)).ToArray();
    HashSet<char> result = new(digitArray);
    return (result.Count);
}
