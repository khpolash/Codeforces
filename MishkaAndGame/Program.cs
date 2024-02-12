// See https://aka.ms/new-console-template for more information
Console.WriteLine("703A\tMishka and Game!");
Console.WriteLine("===========================\n");

int n = int.Parse(Console.ReadLine()!);

int mishkaWin = 0;
int chrisWin = 0;
for (int i = 0; i < n; i++)
{
    int[] ints = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    if (ints[0] > ints[1])
    {
        mishkaWin++;
    }
    else if (ints[0] < ints[1])
    {
        chrisWin++;
    }

}

Console.WriteLine(mishkaWin > chrisWin ? "Mishka" : chrisWin > mishkaWin ? "Chris" : "Friendship is magic!^^");
