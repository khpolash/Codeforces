int n = int.Parse(Console.ReadLine()!);
string[] positions = new string[n];
for (int i = 0; i < positions.Length; i++)
{
    positions[i] = Console.ReadLine()!;
}
int groups = CountGroup(positions);
Console.WriteLine(groups);
static int CountGroup(string[] positions)
{
    int groups = 1;
    for (int i = 1; i < positions.Length; i++)
    {
        if (positions[i] != positions[i - 1])
        {
            groups++;
        }
    }
    return groups;
}