namespace ShapesLib
{
    public abstract class Shape
    {
        /// <summary>
        /// Tolerance value for comparisons
        /// </summary>
        public const double Tolerance = 0.0000001;

        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>Shape's area</returns>
        public abstract double CalculateArea();

        /// <summary>
        /// Calculates the area of the shape.
        /// This method will dynamically dispatch call to the appropriate implementation.
        /// </summary>
        /// <param name="shape"></param>
        /// <returns>Shape's area</returns>
        public static double CalculateArea(Shape shape) => shape.CalculateArea();
    }
}