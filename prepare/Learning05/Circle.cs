public class Circle : Shape //Circle child and inherited from Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)  //Easy:in Cirlce class two parameters but color is inharitated from the base
    {
        _radius = radius; //Initialized
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _radius * _radius * Math.PI; //Calculation part which can be then returned from calling section
    }
}