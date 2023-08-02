class Circle : Shape
{
    private double Radius { get; set; }

    private Circle(string name, double radius) 
    : base(name) {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }
}