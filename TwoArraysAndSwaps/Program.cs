// See https://aka.ms/new-console-template for more information
Console.WriteLine("1353A Two Arrays And Swaps!");
Console.WriteLine("=============================\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine()!.Split();

    int arrayLength = int.Parse(input[0]);
    int minMove = int.Parse(input[1]);

    int[] arrA = new int[arrayLength];
    arrA = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int[] arrB = new int[arrayLength];
    arrB = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    for (int j = 0; j < minMove; j++)
    {
        int minA = arrA.Min();
        int maxB = arrB.Max();
        if (minA < maxB)
        {
            int indexA = Array.IndexOf(arrA, minA);
            int indexB = Array.IndexOf(arrB, maxB);

            int temp = arrA[indexA];
            arrA[indexA] = arrB[indexB];
            arrB[indexB] = temp;
        }
    }

    Console.WriteLine(arrA.Sum());
}