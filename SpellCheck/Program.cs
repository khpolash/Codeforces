// See https://aka.ms/new-console-template for more information
Console.WriteLine("1722A Spell Check!\n");


int t = int.Parse(Console.ReadLine()!);
char[] target = "Timur".ToCharArray();
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string input = Console.ReadLine()!;
    char[] nameArray = new char[n];
    for (int j = 0; j < n; j++)
    {
        nameArray[j] = input[j];
    }
    Array.Sort(target);
    Array.Sort(nameArray);
    bool result = target.SequenceEqual(nameArray);
    Console.WriteLine(result ? "YES" : "NO");
}