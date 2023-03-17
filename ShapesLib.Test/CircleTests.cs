namespace ShapesLib.Test;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void Circle_CorrectArea()
    {
        var circle = new Circle { Radius = 5 };
        var area = circle.CalculateArea();

        Assert.AreEqual(78.539816339745, area, Shape.Tolerance);
    }

    [TestMethod]
    public void Circle_InvalidRadius_ThrowsArgumentException() =>
        Assert.ThrowsException<ArgumentException>(() => new Circle { Radius = -3 });
}