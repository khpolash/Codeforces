int n = int.Parse(Console.ReadLine()!);

int currentCapacity = 0;
int minCapacity = 0;

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()!.Split();
    int passengersExiting = int.Parse(input[0]);
    int passengersEntering = int.Parse(input[1]);
    currentCapacity = currentCapacity - passengersExiting + passengersEntering;
    minCapacity = Math.Max(minCapacity, currentCapacity);
}

Console.WriteLine(minCapacity.ToString());