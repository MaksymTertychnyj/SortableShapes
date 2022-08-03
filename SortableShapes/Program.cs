using SortableShapes;

var side = 1.1234D;
var radius = 1.1234D;
var _base = 5D;
var height = 2D;

var shapes = new List<Shape>
{
    new Square(side),
    new Circle(radius),
    new Triangle(_base, height)
};

shapes.Sort();

foreach (var shape in shapes)
{
    Console.WriteLine($"type: {shape.GetType().Name}, area: {shape.GetArea()}");
}
