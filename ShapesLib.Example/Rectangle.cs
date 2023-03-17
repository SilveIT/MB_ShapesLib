using ShapesLib;

namespace ShapesLib.Example;

//It's quite easy to add new shapes while using the library

/// <summary>
/// Rectangle shape
/// </summary>
public class Rectangle : Shape
{
    private double _width;
    private double _height;

    /// <summary>
    /// The width of the rectangle
    /// </summary>
    public double Width
    {
        get => _width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width value must be > 0");
            _width = value;
        }
    }

    /// <summary>
    /// The height of the rectangle
    /// </summary>
    public double Height
    {
        get => _height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height value must be > 0");
            _height = value;
        }
    }

    /// <summary>
    /// Calculates the rectangle's area
    /// </summary>
    /// <returns>Rectangle's area</returns>
    public override double CalculateArea() => Width * Height;

    /// <summary>
    /// A method for representing it as a string.
    /// </summary>
    /// <returns>Rectangle as a string</returns>
    public override string ToString() => $"W: {_width}; H: {_height}";
}