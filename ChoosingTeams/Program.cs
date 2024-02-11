// See https://aka.ms/new-console-template for more information
Console.WriteLine("432A\tChoosing Teams");
Console.WriteLine("=========================\n");

string[] inputs = Console.ReadLine()!.Split();

int n = int.Parse(inputs[0]);
int k = int.Parse(inputs[1]);
int teams = 0;
int[] participant = new int[n];
string[] strings = Console.ReadLine()!.Split();
for (int i = 0; i < n; i++)
{

    participant[i] = int.Parse(strings[i]);
}

for (int i = 0; i < n; i++)
{
    if (5 - participant[i] >= k)
    {
        teams++;
    }
}

Console.WriteLine(teams / 3);

