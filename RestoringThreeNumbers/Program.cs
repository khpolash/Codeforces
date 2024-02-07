int[] inputs = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Array.Sort(inputs);
Console.WriteLine($"{inputs[3] - inputs[1]} {inputs[3] - inputs[2]} {inputs[3] - inputs[0]}");