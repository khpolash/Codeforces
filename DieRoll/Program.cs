// See https://aka.ms/new-console-template for more information
Console.WriteLine("9A\tDie Roll!");
Console.WriteLine("=======================\n");

int[] inputs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int maxPoint = Math.Max(inputs[0], inputs[1]);
int winningPossibilities = 6 - maxPoint + 1;
int gcd = GCD(winningPossibilities, 6);
Console.WriteLine($"{winningPossibilities / gcd}/{6 / gcd}");

static int GCD(int a, int b)
{
    return b == 0 ? a : GCD(b, a % b);
}