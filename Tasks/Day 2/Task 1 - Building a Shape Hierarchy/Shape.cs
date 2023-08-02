public class Shape {
    private string Name;

    public Shape(string name) {
        Name = name;
    }

    public virtual double CalculateArea() {
        // override for each shape and calculate the area
        return 0;
    }

    public virtual void PrintShapeArea() {
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Area: {this.CalculateArea()}");
        System.Console.WriteLine();
    }
}