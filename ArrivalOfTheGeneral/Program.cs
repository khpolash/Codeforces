int n = int.Parse(Console.ReadLine()!);
string[] values = Console.ReadLine()!.Split();
int maxvalue = 0;
int minvalue = 1000;
int maxindex = 0;
int minindex = 0;

for (int i = 0; i < n; i++)
{
    int x = int.Parse(values[i]);

    if (x > maxvalue)
    {
        maxindex = i;
        maxvalue = x;
    }

    if (x <= minvalue)
    {
        minindex = i;
        minvalue = x;
    }
}

Console.WriteLine((maxindex > minindex) ? ((maxindex - 1) + (n - minindex) - 1) : ((maxindex - 1) + (n - minindex)));
