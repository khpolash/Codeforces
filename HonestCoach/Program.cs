// See https://aka.ms/new-console-template for more information
Console.WriteLine("1360B Honest Coach!\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] arr = new int[n];
    string[] inputs = Console.ReadLine()!.Split();

    for (int j = 0; j < n; j++)
    {
        arr[j] = int.Parse(inputs[j]);
    }

    Array.Sort(arr);

    int result = arr[arr.Length - 1] - arr[0];

    for (int k = 0; k < n; k++)
    {
        for (int l = k + 1; l < n; l++)
        {
            result = Math.Min(result, (arr[l] - arr[k]));
        }
    }

    Console.WriteLine(result);

}
