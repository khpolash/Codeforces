int n = int.Parse(Console.ReadLine()!);

int[] levelsX = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int[] levelsY = Console.ReadLine()!.Split().Select(int.Parse).ToArray();


string result = CanPassWholeGame(n, levelsX, levelsY);
Console.WriteLine(result);

static string CanPassWholeGame(int n, int[] levelsX, int[] levelsY)
{
    HashSet<int> allLevels = new(Enumerable.Range(1, n));

    HashSet<int> levelsXSet = new(levelsX.Skip(1));
    HashSet<int> levelsYSet = new(levelsY.Skip(1));

    HashSet<int> unionSet = new HashSet<int>(levelsXSet);
    unionSet.UnionWith(levelsYSet);

    return (unionSet.SetEquals(allLevels)) ? "I become the guy." : "Oh, my keyboard!";
}
