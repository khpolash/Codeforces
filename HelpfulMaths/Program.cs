string input = Console.ReadLine()!;
int[] number = Array.ConvertAll(input.Split("+"), int.Parse);
Array.Sort(number);
string result = string.Join("+", number);
Console.WriteLine(result);
