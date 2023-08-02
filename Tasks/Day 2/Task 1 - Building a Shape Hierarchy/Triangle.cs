public class Triangle : Shape {
    private double Base {get; set;}
    private double Height {get; set;}

    public Triangle(string name, double baseTr, double height)
    : base(name) {
        Base = baseTr;
        Height = height;
    }

    public override double CalculateArea()
    {
        return (Base * Height) / 2;
    }
}