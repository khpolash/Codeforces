// See https://aka.ms/new-console-template for more information


Console.WriteLine("1472B Fair Division!");
Console.WriteLine("===========================\n");

int t = int.Parse(Console.ReadLine()!);
for (int i = 0; i < t; i++)
{
    long n = long.Parse(Console.ReadLine()!);
    string[] input = Console.ReadLine()!.Split();
    int[] candyArray = new int[n];
    for (long j = 0; j < n; j++)
    {
        candyArray[j] = int.Parse(input[j]);
    }

    bool result = CanDivideCandies(candyArray);
    Console.WriteLine(result == true ? "YES" : "NO");
}

static bool CanDivideCandies(int[] candyArray)
{
    int weightOne = candyArray.Count(x => x == 1);
    int weightTwo = candyArray.Count(x => x == 2);
    if ((weightOne + 2 * weightTwo) % 2 != 0)
    {
        return false;
    }
    else
    {
        int sum = (weightOne + 2 * weightTwo) / 2;
        if (sum % 2 == 0 || (sum % 2 == 1 && weightOne != 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

//     2 1 1 1 1
//     1 1 2 2 2 2 2 2

//     1 1 1 1 1 2 2 2 2 1

//     2 1 2 1 1 2 2 2 1 1

//     2 1 1 2 1 2 2 2 1

//If the sum of all the weights is not divisible by two, then it is impossible to divide the candies between two people. If the sum is divisible, then let's count the number of candies with a weight of 1 and 2. Now, if we can find a way to collect half the sum with some candies, then these candies can be given to Alice, and all the rest can be given to Bob. Simple solution — let's iterate through how many candies of weight 2 we will give to Alice, then the remaining weight should be filled by candies of weight 1. If there are enough of them, then we have found a way of division. In fact, if the sum is even and there are at least two candies with weight 1 (there can't be one candy), then the answer is always "YES" (we can collect the weight as close to half as possible with weight 2 and then add weight 1). If there are no candies with weight 1, then you need to check whether n is even (since all the candies have the same weight, you just need to divide them in half)