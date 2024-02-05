string input = Console.ReadLine()!;

int totalUpper = input.Count(c => char.IsUpper(c));
int totalLower = input.Count(c => char.IsLower(c));
Console.WriteLine(totalLower >= totalUpper ? input.ToLower() : input.ToUpper());
