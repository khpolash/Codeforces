string[] input = Console.ReadLine()!.Split();
string[] height = Console.ReadLine()!.Split();

int n = int.Parse(input[0]);
decimal h = decimal.Parse(input[1]);
int result = 0;
for (int i = 0; i < n; i++)
{
    result += (int)Math.Ceiling(int.Parse(height[i]) / h);
}
Console.WriteLine(result.ToString());