// See https://aka.ms/new-console-template for more information

Console.WriteLine("431A\tBlack Square!");
Console.WriteLine("=========================\n");

int[] calories = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

string gameString = Console.ReadLine()!;

int totalCalories = CalculateTotalCalories(calories, gameString);

Console.WriteLine(totalCalories);
static int CalculateTotalCalories(int[] calories, string gameString)
{
    int totalCalories = 0;

    foreach (char cal in gameString)
    {
        int strip = int.Parse(cal.ToString()) - 1;
        totalCalories += calories[strip];
    }
    return totalCalories;
}