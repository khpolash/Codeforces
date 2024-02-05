int n = int.Parse(Console.ReadLine()!);
string[] input = Console.ReadLine()!.Split();
int[] result = new int[n];
for (int i = 0; i < n; i++)
{
    int giftGiver = int.Parse(input[i]);
    result[giftGiver - 1] = i + 1;
}

Console.WriteLine(string.Join(" ", result));
