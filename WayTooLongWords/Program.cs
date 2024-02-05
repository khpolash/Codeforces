
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    string inputWord = Console.ReadLine()!;
    string result = AbbreviateIfTooLong(inputWord);
    Console.WriteLine(result);
}
static string AbbreviateIfTooLong(string word)
{
    if (word.Length > 10)
    {
        int omittedLetters = word.Length - 2;
        return $"{word[0]}{omittedLetters}{word[^1]}";
    }
    else
    {
        return word;
    }
}

