
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    int[] inputs = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

    int diff = Math.Abs(inputs[0] - inputs[1]);
    int moves = (diff / 10) + (diff % 10 == 0 ? 0 : 1);
    Console.WriteLine(moves);
}

