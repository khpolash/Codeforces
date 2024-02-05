string input = Console.ReadLine()!;
int result = new HashSet<char>(input).Count;
Console.WriteLine(result % 2 == 0 ? "CHAT WITH HER!" : "IGNORE HIM!");