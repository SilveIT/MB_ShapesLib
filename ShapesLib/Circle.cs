namespace ShapesLib;

public class Circle : Shape
{
    private double _radius;

    /// <summary>
    /// The radius of the circle
    /// </summary>
    public double Radius
    {
        get => _radius;
        set
        {
            if (value < 0)
                throw new ArgumentException("Radius value must be >= 0");
            _radius = value;
        }
    }

    /// <summary>
    /// Calculates the circle's area
    /// </summary>
    /// <returns>Circle's area</returns>
    public override double CalculateArea() => Math.PI * Math.Pow(_radius, 2);

    /// <summary>
    /// A method for representing it as a string.
    /// </summary>
    /// <returns>Circle as a string</returns>
    public override string ToString() => "R: " + Radius;
}