using System;
using System.Text;

class Triangle
{
    protected double x1, y1, x2, y2, x3, y3;

    public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        SetCoordinates(x1, y1, x2, y2, x3, y3);
    }

    public void SetCoordinates(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
    }

    public void DisplayCoordinates()
    {
        Console.WriteLine("Координати трикутника:");
        Console.WriteLine($"Точка 1: ({x1}, {y1})");
        Console.WriteLine($"Точка 2: ({x2}, {y2})");
        Console.WriteLine($"Точка 3: ({x3}, {y3})");
    }

    public double GetArea()
    {
        return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
    }
}

class Tetrahedron : Triangle
{
    private double x4, y4, z1, z2, z3, z4;

    public Tetrahedron(double x1, double y1, double z1, double x2, double y2, double z2, double x3, double y3, double z3, double x4, double y4, double z4)
        : base(x1, y1, x2, y2, x3, y3)
    {
        SetVertices(x1, y1, z1, x2, y2, z2, x3, y3, z3, x4, y4, z4);
    }

    public void SetVertices(double x1, double y1, double z1, double x2, double y2, double z2, double x3, double y3, double z3, double x4, double y4, double z4)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.z1 = z1;
        this.x2 = x2;
        this.y2 = y2;
        this.z2 = z2;
        this.x3 = x3;
        this.y3 = y3;
        this.z3 = z3;
        this.x4 = x4;
        this.y4 = y4;
        this.z4 = z4;
    }

    public void DisplayVertices()
    {
        Console.WriteLine("Координати тетраедра:");
        Console.WriteLine($"Точка 1: ({x1}, {y1}, {z1})");
        Console.WriteLine($"Точка 2: ({x2}, {y2}, {z2})");
        Console.WriteLine($"Точка 3: ({x3}, {y3}, {z3})");
        Console.WriteLine($"Точка 4: ({x4}, {y4}, {z4})");
    }

    public double GetVolume()
    {
        double volume = Math.Abs((x1 * (y2 * (z3 - z4) + y3 * (z4 - z2) + y4 * (z2 - z3)) -
                                  x2 * (y1 * (z3 - z4) + y3 * (z4 - z1) + y4 * (z1 - z3)) +
                                  x3 * (y1 * (z2 - z4) + y2 * (z4 - z1) + y4 * (z1 - z2)) -
                                  x4 * (y1 * (z2 - z3) + y2 * (z3 - z1) + y3 * (z1 - z2))) / 6.0);
        return volume;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;


        Triangle triangle = new Triangle(0, 0, 3, 0, 0, 4);
        triangle.DisplayCoordinates();
        Console.WriteLine("Площа трикутника: " + triangle.GetArea());

        Tetrahedron tetrahedron = new Tetrahedron(0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1);
        tetrahedron.DisplayVertices();
        Console.WriteLine("Об'єм тетраедра: " + tetrahedron.GetVolume());

        Console.ReadKey();
    }
}