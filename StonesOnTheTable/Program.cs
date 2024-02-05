int n = int.Parse(Console.ReadLine()!);
string input = Console.ReadLine()!;
int minRemove = 0;
for (int i = 1; i < n; i++)
{
    if (input[i] == input[i - 1])
    {
        minRemove++;
    }
}
Console.WriteLine(minRemove);