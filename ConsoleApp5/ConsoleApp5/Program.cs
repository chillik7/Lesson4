using System;

abstract class Shape3D
{
    public abstract double CalculateVolume();

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Это трехмерная фигура.");
    }
}
class Sphere : Shape3D
{
    public double Radius { get; }

    public Sphere(double radius)
    {
        Radius = radius;
    }

    public override double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Сфера с радиусом {Radius}");
        Console.WriteLine($"Объем: {CalculateVolume():F2}");
    }
}

class Cube : Shape3D
{
    public double SideLength { get; }

    public Cube(double sideLength)
    {
        SideLength = sideLength;
    }
    public override double CalculateVolume()
    {
        return Math.Pow(SideLength, 3);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Куб с длиной ребра {SideLength}");
        Console.WriteLine($"Объем: {CalculateVolume():F2}");
    }
}
class Program
{
    static void Main()
    {
        Shape3D sphere = new Sphere(5);
        Shape3D cube = new Cube(4);

        sphere.DisplayInfo();
        Console.WriteLine();
        cube.DisplayInfo();
    }
}

