// See https://aka.ms/new-console-template for more information
Console.WriteLine("1791A Codeforces Checking!");
Console.WriteLine("==============================\n");

int t = int.Parse(Console.ReadLine()!);

string str = "codeforces";

for (int i = 0; i < t; i++)
{
    char a = char.Parse(Console.ReadLine()!.ToLower());
    Console.WriteLine(str.Contains(a) ? "YES" : "NO");
}

