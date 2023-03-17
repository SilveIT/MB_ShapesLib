namespace ShapesLib.Test;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void CorrectAreaAndValidSides()
    {
        //Yes, it would've looked better if it had some constructors. Oh, well...
        var triangle = new Triangle { ASide = 3, BSide = 4, CSide = 5 };
        var area = triangle.CalculateArea();

        Assert.AreEqual(6, area, Shape.Tolerance);
    }

    [TestMethod]
    public void NegativeSide_ThrowsArgumentException() => 
        Assert.ThrowsException<ArgumentException>(() => new Triangle { ASide = -1, BSide = 2, CSide = 3 });

    [TestMethod]
    public void IsRight_ReturnsTrue()
    {
        var triangle = new Triangle { ASide = 3, BSide = 4, CSide = 5 };
        var isRight = triangle.IsRight();

        Assert.IsTrue(isRight);
    }

    [TestMethod]
    public void IsRight_ReturnsFalse()
    {
        var triangle = new Triangle { ASide = 3, BSide = 4, CSide = 6 };
        var isRight = triangle.IsRight();

        Assert.IsFalse(isRight);
    }

    [TestMethod]
    public void IsValid_ZeroSide_ReturnsFalse()
    {
        var triangle = new Triangle { ASide = 1, BSide = 2 };
        var result = triangle.IsValid();

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsValid_InvalidSides_ReturnsFalse()
    {
        var triangle = new Triangle { ASide = 1, BSide = 2, CSide = 4 };
        var result = triangle.IsValid();

        Assert.IsFalse(result);
    }
}