string[] inputs = Console.ReadLine()!.Split();
int k = int.Parse(inputs[0]);
int n = int.Parse(inputs[1]);
int w = int.Parse(inputs[2]);
int totalCost = ((w * (w + 1)) / 2) * k;
int borrowAmount = Math.Max(0, totalCost - n);
Console.WriteLine(borrowAmount.ToString());