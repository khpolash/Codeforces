// See https://aka.ms/new-console-template for more information
Console.WriteLine("1560A\tDislike of Threes");
Console.WriteLine("============================\n");

int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int k = int.Parse(Console.ReadLine()!);
    int result = FindKthElement(k);
    Console.WriteLine(result);
}
static int FindKthElement(int k)
{
    int count = 0;
    int num = 1;

    while (count < k)
    {
        if (num % 3 != 0 && num % 10 != 3)
        {
            count++;
        }
        num++;
    }
    return num - 1;
}