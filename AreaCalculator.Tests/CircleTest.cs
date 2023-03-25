using System;
using AreaCalculator.Shapes;
using AreaCalculator.Shapes.Interfaces;
using Xunit;

namespace AreaCalculator.Tests;

public class CircleTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, Math.PI)]
    [InlineData(5.56, 97.1179)]
    public void TestArea(double radius, double expectedArea)
    {
        Shape circle = new Circle(radius);
        var actualArea = circle.CalculateArea();
        
        Assert.Equal(expectedArea, actualArea, precision: 3);
    }
}