string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]);
int k = int.Parse(input[1]);

string[] input2 = Console.ReadLine()!.Split();

int[] inputArray = new int[n];
for (int i = 0; i < n; i++)
{
    inputArray[i] = int.Parse(input2[i]);
}
int participants = 0;

for (int j = 0; j < n; j++)
{
    if (inputArray[j] > 0 && inputArray[j] >= inputArray[k - 1])
    {
        participants++;
    }
    else
    {
        break;
    }
}

Console.WriteLine(participants);