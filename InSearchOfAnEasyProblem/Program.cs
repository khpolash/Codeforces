int n = int.Parse(Console.ReadLine()!);
string[] options = Console.ReadLine()!.Split();
bool isHard = Array.Exists(options, opinion => opinion == "1");
Console.WriteLine(isHard ? "HARD" : "EASY");
