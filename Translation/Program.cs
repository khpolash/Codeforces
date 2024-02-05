string t = Console.ReadLine()!.Trim();
string s = Console.ReadLine()!.Trim();
string reversedString = new(s.Reverse().ToArray());

Console.WriteLine((t.Length == reversedString.Length && t == reversedString) ? "YES" : "NO");
