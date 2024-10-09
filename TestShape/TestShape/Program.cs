using ClassLibrary1;

class Program
{
    static void Main(string[] args)
    {
        IShape circle = ShapeFactory.CreateCircle(5);
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

        IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
        Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");

        Triangle specificTriangle = triangle as Triangle;
        if (specificTriangle != null && specificTriangle.IsRightTriangle())
        {
            Console.WriteLine("This triangle is a right triangle.");
        }
    }
}
