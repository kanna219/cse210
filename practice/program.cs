using System.Drawing;
using System.Reflection.Metadata;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Circle s1 = new Circle("Green", 6);
        Rectangle s2 = new Rectangle("Blue", 4, 5);

        shapes.Add(s1);
        shapes.Add(s2);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} has an area of {shape.GetArea()}.");
        }
    }
}