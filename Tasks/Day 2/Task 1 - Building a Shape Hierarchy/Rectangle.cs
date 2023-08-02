class Rectangle : Shape
{
    private double Width {get; set;}
    private double Height {get; set;}

    public Rectangle(string name, double width, double height)
    : base(name)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}