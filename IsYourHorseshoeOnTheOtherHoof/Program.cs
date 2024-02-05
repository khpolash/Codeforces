string[] color = Console.ReadLine()!.Split();

int color1 = int.Parse(color[0]);
int color2 = int.Parse(color[1]);
int color3 = int.Parse(color[2]);
int color4 = int.Parse(color[3]);

HashSet<int> uniqueColor = new HashSet<int>();
uniqueColor.Add(color1);
uniqueColor.Add(color2);
uniqueColor.Add(color3);
uniqueColor.Add(color4);

Console.WriteLine(4 - uniqueColor.Count);