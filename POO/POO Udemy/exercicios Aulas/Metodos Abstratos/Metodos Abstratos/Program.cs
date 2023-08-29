
using Metodos_Abstratos.Entities.Enums;
using Metodos_Abstratos.Entities;
using Metodos_Abstratos;
using System.Globalization;

List<Shapes> shapes = new List<Shapes>();
Console.WriteLine("Enter the number of sahpes:");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Shapes Shape;
    Console.WriteLine("Rectangle or Circle (r/c)?");
    char resp = char.Parse(Console.ReadLine());
    Console.WriteLine("Color (Black/Blue/Red)?");
    Color color = Enum.Parse<Color>(Console.ReadLine());
    if (resp == 'c')
    {
        Console.WriteLine("Radius");
        double r = double.Parse(Console.ReadLine());
        Shape = new Circle(r, color);

    }
    else
    {
        Console.WriteLine("Width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Heigth:");
        double height = double.Parse(Console.ReadLine());
        Shape = new Rectangle(width, height, color);

    }
    shapes.Add(Shape);
}
Console.WriteLine("Shapes Areas:");
foreach (Shapes shape in shapes)
{
   Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
}
