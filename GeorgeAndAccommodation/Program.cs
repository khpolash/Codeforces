int roomNumber = int.Parse(Console.ReadLine()!);

int canMove = 0;

for (int i = 0; i < roomNumber; i++)
{
    string[] input = Console.ReadLine()!.Split();
    if (int.Parse(input[0]) + 2 <= int.Parse(input[1]))
    {
        canMove++;
    }
}
Console.WriteLine(canMove.ToString());