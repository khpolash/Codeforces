string str1 = Console.ReadLine()!;
string str2 = Console.ReadLine()!;

int result = string.Compare(str1.ToLower(), str2.ToLower());

if (result < 0)
{
    Console.WriteLine("-1");
}
else if (result > 0)
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}
