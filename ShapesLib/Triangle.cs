namespace ShapesLib;

/// <summary>
/// Triangle shape
/// </summary>
public class Triangle : Shape
{
    private double _aSide;
    private double _bSide;
    private double _cSide;

    /// <summary>
    /// The length of A side
    /// </summary>
    public double ASide
    {
        get => _aSide;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Side A value must be > 0");
            _aSide = value;
        }
    }

    /// <summary>
    /// The length of B side
    /// </summary>
    public double BSide
    {
        get => _bSide;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Side B value must be > 0");
            _bSide = value;
        }
    }

    /// <summary>
    /// The length of C side
    /// </summary>
    public double CSide
    {
        get => _cSide;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Side C value must be > 0");
            _cSide = value;
        }
    }

    /// <summary>
    /// Calculates the triangle's area
    /// </summary>
    /// <returns>Triangle's area</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public override double CalculateArea()
    {
        if (!IsValid())
            throw new InvalidOperationException("The sides for current triangle are invalid!");

        var s = (_aSide + _bSide + _cSide) / 2;
        return Math.Sqrt(s * (s - _aSide) * (s - _bSide) * (s - _cSide));
    }

    /// <summary>
    /// Checks if triangle is right by it's 3 sides
    /// </summary>
    /// <returns>True if this triangle is right</returns>
    public bool IsRight()
    {
        if (!IsValid())
            throw new InvalidOperationException("The sides for current triangle are invalid!");

        var sides = new[] { _aSide, _bSide, _cSide };
        //The smaller sides should be compared to the biggest side, so let's sort them
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < Tolerance;
    }

    /// <summary>
    /// Checks if the triangle with current sides is possible
    /// </summary>
    /// <returns>True if triangle is possible</returns>
    public bool IsValid()
    {
        //All sides must be positive (they are 0 by default, so check it anyway, since we have a parameterless constructor)
        if (_aSide <= 0 || _bSide <= 0 || _cSide <= 0)
            return false;

        //Sum of any two sides must be greater than the third side
        return !(_aSide + _bSide <= _cSide) && !(_aSide + _cSide <= _bSide) && !(_bSide + _cSide <= _aSide);
    }

    /// <summary>
    /// A method for representing it as a string.
    /// </summary>
    /// <returns>Triangle as a string</returns>
    public override string ToString() => $"A: {_aSide}; B: {_bSide}; C: {_cSide}";
}