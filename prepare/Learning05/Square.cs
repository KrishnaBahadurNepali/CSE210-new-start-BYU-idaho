public class Square : Shape //Square a child class iherited from Shape Just like circle
{
    private double _side;

    public Square(string color, double side) : base (color) //Get one parameter from Inherited base class
    {
        _side = side;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _side * _side;
    }
}