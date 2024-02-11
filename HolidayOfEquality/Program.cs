// See https://aka.ms/new-console-template for more information
Console.WriteLine("158A\tHoliday Of Equality");
Console.WriteLine("===========================\n");

int n = int.Parse(Console.ReadLine()!);
int count = 0;
int[] ints = new int[n];

string[] inputs = Console.ReadLine()!.Split();

for (int i = 0; i < n; i++)
{
    ints[i] = int.Parse(inputs[i]);
}

Array.Sort(ints);

int max = ints.Max();

while (n > 0)
{
    n--;
    count += max - ints[n];
}

Console.WriteLine(count);