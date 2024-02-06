int testCase = int.Parse(Console.ReadLine()!);
string[] events = Console.ReadLine()!.Split();
int totalOfficers = 0;
int untreatedCrimes = 0;

for (int i = 0; i < testCase; i++)
{
    int eventValue = int.Parse(events[i]);
    switch (eventValue)
    {
        case -1:
            switch (totalOfficers)
            {
                case 0:
                    untreatedCrimes++;
                    break;
                default:
                    totalOfficers--;
                    break;
            }
            break;
        default:
            totalOfficers += eventValue;
            break;
    }
}
Console.WriteLine(untreatedCrimes);