// See https://aka.ms/new-console-template for more information
Console.WriteLine("490A\tTeam Olympiad");
Console.WriteLine("=========================\n");

int n = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();

int[] skils = new int[n];

for (int i = 0; i < n; i++)
{
    skils[i] = int.Parse(inputs[i]);
}

int tOne = skils.Count(x => x == 1);
int tTwo = skils.Count(x => x == 2);
int tThree = skils.Count(x => x == 3);

int tGroup = Math.Min(tOne, Math.Min(tTwo, tThree));
Console.WriteLine(tGroup);

List<int> team = new List<int>(skils);

for (int i = 0; i < tGroup; i++)
{
    int indexOne = team.FindIndex(x => x == 1);
    int indexTwo = team.FindIndex(x => x == 2);
    int indexThree = team.FindIndex(x => x == 3);

    Console.WriteLine($"{indexOne + 1} {indexTwo + 1} {indexThree + 1}");

    team[indexOne] = 0;
    team[indexTwo] = 0;
    team[indexThree] = 0;
}