
int n = int.Parse(Console.ReadLine()!);
int totalFace = 0;

for (int i = 0; i < n; i++)
{
    string polyhedron = Console.ReadLine()!;
    if (Enum.TryParse(polyhedron, out PolyhedronType type))
    {
        totalFace += (int)type;
    }
}
Console.WriteLine(totalFace);

enum PolyhedronType
{
    Tetrahedron = 4,
    Cube = 6,
    Octahedron = 8,
    Dodecahedron = 12,
    Icosahedron = 20
}
