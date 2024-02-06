int[] inputs = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
Array.Sort(inputs);

int medium = inputs[1];

int minimumDistance = Math.Abs(inputs[0] - medium) + Math.Abs(inputs[1] - medium) + Math.Abs(inputs[2] - medium);

Console.WriteLine(minimumDistance);