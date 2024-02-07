string[] inputs = Console.ReadLine()!.Split();

int k = int.Parse(inputs[0]);
int r = int.Parse(inputs[1]);

int minNumberOfShovel = 1;

while ((k * minNumberOfShovel) % 10 != 0 && (k * minNumberOfShovel) % 10 != r)
{
    minNumberOfShovel++;
}

Console.WriteLine(minNumberOfShovel);