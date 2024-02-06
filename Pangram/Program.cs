int n = int.Parse(Console.ReadLine()!);
string input = Console.ReadLine()!;

Console.WriteLine(IsPangram(input) ? "YES" : "NO");

static bool IsPangram(string str)
{
    return str.ToLower().Where(c => char.IsLetter(c)).GroupBy(c => c).Count() == 26;
}