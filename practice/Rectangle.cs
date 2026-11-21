class Rectangle : Shape
{
    private double _length;
    private double _side;

    public Rectangle(string color, double length, double side)
    : base(color)
    {
        _length = length;
        _side = side;
    }

    public override double GetArea()
    {
        return _length * _side;
    }

}