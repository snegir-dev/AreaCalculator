using AreaCalculator.Shapes.Interfaces;

namespace AreaCalculator.Shapes;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius) =>
        Radius = radius;
    
    public override double CalculateArea() =>
        Math.PI * Math.Pow(Radius, 2);
}