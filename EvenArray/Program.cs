// See https://aka.ms/new-console-template for more information
Console.WriteLine("1367B\tEven Array!");
Console.WriteLine("===========================\n");


int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine()!);
    string[] str = Console.ReadLine()!.Split();
    int[] arr = new int[n];
    int even = 0, odd = 0;
    for (int j = 0; j < n; j++)
    {
        arr[j] = int.Parse(str[j]);
    }

    for (int k = 0; k < arr.Length; k++)
    {
        if (k % 2 != arr[k] % 2)
        {
            switch (arr[k] % 2)
            {
                case 1:
                    odd++;
                    break;
                default:
                    even++;
                    break;
            }
        }
    }

    Console.WriteLine(odd != even ? -1 : even);
}
