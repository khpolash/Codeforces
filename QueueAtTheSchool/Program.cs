string[] input = Console.ReadLine()!.Split();
string s = Console.ReadLine()!.ToUpper();
char[] queue = s.ToCharArray();
int n = int.Parse(input[0]);
int t = int.Parse(input[1]);

char temp;

for (int time = 0; time < t; time++)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (queue[i] == 'B' && queue[i + 1] == 'G')
        {
            temp = queue[i];
            queue[i] = queue[i + 1];
            queue[i + 1] = temp;
            i++;
        }
    }
}
Console.WriteLine(new string(queue));