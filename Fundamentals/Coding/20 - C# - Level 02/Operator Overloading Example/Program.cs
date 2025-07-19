using System;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overloading the + operator for point addition
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    // Overloading the == operator for fraction equality
    public static bool operator == (Point p1, Point p2)
    {
        return (p1.X == p2.X) && (p1.Y == p2.Y);
    }

    // Overloading the != operator for fraction equality
    public static bool operator !=(Point p1, Point p2)
    {
        return (p1.X != p2.X) || (p1.Y != p2.Y);
    }

    // Overriding ToString for better readability
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main()
    {
        Point point1 = new Point(1, 2);
        Point point2 = new Point(3, 4);

        // Using the overloaded + operator for point addition
        Point point3 = point1 + point2;

        // Using the overloaded + operator for point addition
        Point point4 = point1 - point2;


        Console.WriteLine($"Point1 : {point1.ToString()}");
        Console.WriteLine($"Point2 : {point2.ToString()}");

        Console.WriteLine($"Point3 is the result of point1 + point2: {point3.ToString()}");
        Console.WriteLine($"Point4 is the result of point1 - point2: {point4.ToString()}");

        // Using the overloaded == operator for point equality
        if (point1 == point2)
            Console.WriteLine("Using == : Yes, Point1 = Point2");
        else
            Console.WriteLine("Using == : No, Piont1 does not equal Point2");

        // Using the overloaded != operator for point inequality
        if (point1 != point2)
            Console.WriteLine("Using != : Yes, Piont1 does not equal Point2");
        else
            Console.WriteLine("Using != : No, Piont1 = Point2");

        Console.ReadKey();

    }
}
