string input = Console.ReadLine()!;
string input1 = Console.ReadLine()!;
System.Text.StringBuilder sb = new System.Text.StringBuilder();
for (int i = 0; i < input.Length; i++)
{
    int digit1 = input[i] - '0';
    int digit2 = input1[i] - '0';
    int answer = digit1 ^ digit2;
    sb.Append(answer);
}
Console.WriteLine(sb.ToString());
