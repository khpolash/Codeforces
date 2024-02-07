
string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]);
int k = int.Parse(inputs[1]);
int l = int.Parse(inputs[2]);
int c = int.Parse(inputs[3]);
int d = int.Parse(inputs[4]);
int p = int.Parse(inputs[5]);
int nl = int.Parse(inputs[6]);
int np = int.Parse(inputs[7]);

Console.WriteLine(CalculateToasts(n, k, l, c, d, p, nl, np));

static int CalculateToasts(int n, int k, int l, int c, int d, int p, int nl, int np)
{
    int totalDrink = (k * l) / nl;
    int totalLimes = c * d;
    int totalSalt = p / np;

    int toasts = Math.Min(totalDrink, Math.Min(totalLimes, totalSalt));
    return toasts / n;
}