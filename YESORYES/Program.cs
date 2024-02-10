// See https://aka.ms/new-console-template for more information
Console.WriteLine("1703A YES or YES?");
Console.WriteLine("===================");

int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    string inputs = Console.ReadLine()!.ToLower();
    Console.WriteLine((inputs == "yes") ? "YES" : "NO");
}