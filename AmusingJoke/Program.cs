
string guestName = Console.ReadLine()!;
string hostName = Console.ReadLine()!;
string pileOfLetters = Console.ReadLine()!;

string combinedNames = $"{guestName}{hostName}";

Console.WriteLine(CanPermuteNames(combinedNames, pileOfLetters) ? "YES" : "NO");

static bool CanPermuteNames(string combinedNames, string pileOfLetters)
{
    if (combinedNames.Length != pileOfLetters.Length)
    {
        return false;
    }
    char[] combinedNamesArray = combinedNames.ToCharArray();
    char[] pileOfLettersArray = pileOfLetters.ToCharArray();
    Array.Sort(combinedNamesArray);
    Array.Sort(pileOfLettersArray);

    return combinedNamesArray.SequenceEqual(pileOfLettersArray);
}