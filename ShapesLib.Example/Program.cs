namespace ShapesLib.Example
{
    internal class Program
    {
        //It can be static readonly, but cannot be const, since it requires non-compile time expressions
        private static readonly double SomeCircleArea = Shape.CalculateArea(new Circle { Radius = 5 });

        private static void Main()
        {
            //The shapes from the library:
            var circle = new Circle { Radius = 5 };
            var triangle = new Triangle { ASide = 3, BSide = 4, CSide = 5 };
            //The app-side implemented rectangle class based on the library:
            var rectangle = new Rectangle { Width = 2, Height = 5 };
            //There's no need to know the shape's type at compile-time to calculate it's area,
            //but the area itself will be calculated at runtime in any scenario (since it requires an object)

            Console.WriteLine($"Circle {circle}, it's area: {circle.CalculateArea()}");
            Console.WriteLine($"Triangle {triangle}, it's area: {triangle.CalculateArea()}");
            Console.WriteLine("Same but dynamically dispatched:");
            Console.WriteLine($"Circle {circle}, it's area: {Shape.CalculateArea(circle)}");
            Console.WriteLine($"Triangle {triangle}, it's area: {Shape.CalculateArea(triangle)}");
            Console.WriteLine($"Rectangle {rectangle}, it's area: {Shape.CalculateArea(rectangle)}");
            Console.WriteLine($"Triangle {triangle}, is valid: {triangle.IsValid()}");
            Console.WriteLine($"Triangle {triangle}, is right: {triangle.IsRight()}");

            Console.ReadKey();
        }
    }
}