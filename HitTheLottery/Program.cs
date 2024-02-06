
int n = int.Parse(Console.ReadLine()!);

int bills100 = n / 100;
int bills20 = (n % 100) / 20;
int bills10 = ((n % 100) % 20) / 10;
int bills5 = (((n % 100) % 20) % 10) / 5;
int bills1 = (((n % 100) % 20) % 10) % 5;

int totalBills = bills100 + bills20 + bills10 + bills5 + bills1;

Console.WriteLine(totalBills);