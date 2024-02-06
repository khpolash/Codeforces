string[] inputs = Console.ReadLine()!.Split();

int minSocks = Math.Min(int.Parse(inputs[0]), int.Parse(inputs[1]));
int maxSocks = Math.Max(int.Parse(inputs[0]), int.Parse(inputs[1]));

int dayDiffSocks = minSocks;
int daySameSocks = (maxSocks - minSocks) / 2;

Console.WriteLine($"{dayDiffSocks} {daySameSocks}");