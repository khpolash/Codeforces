// See https://aka.ms/new-console-template for more information
Console.WriteLine("32B\tBorze");
Console.WriteLine("======================\n");

string inputs = Console.ReadLine()!;
char[] ch = inputs.ToCharArray();

string ternaryNumber = string.Empty;

for (int i = 0; i < inputs.Length; i++)
{
    if (ch[i] == '.')
    {
        ternaryNumber += '0';
    }
    else if (i < ch.Length && ch[i] == '-' && ch[i + 1] == '.')
    {
        ternaryNumber += '1';
        i++;
    }
    else if (i < ch.Length && ch[i] == '-' && ch[i + 1] == '-')
    {
        ternaryNumber += '2';
        i++;
    }
}

Console.WriteLine(ternaryNumber);
