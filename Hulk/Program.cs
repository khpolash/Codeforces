using System.Text;

int n = int.Parse(Console.ReadLine()!);

StringBuilder sb = new StringBuilder();

for (int i = 1; i <= n; i++)
{
    sb.Append("I ").Append(i % 2 == 1 ? "hate" : "love");
    if (i < n)
        sb.Append(" that ");
}
sb.Append(" it");

Console.WriteLine(sb.ToString());