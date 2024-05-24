using System;

class Program
{
    static void Main(string[] args)
    {
        //  list is a list of "Shape" objects. That means you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>(); //List of the Shape

        Square s1 = new Square("Red", 3); //These parameter can be get from user as well
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5); //Three parameter is sent
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // all shapes have a GetColor method from the base class
            string color = s.GetColor(); //Color can be obtained using Getcolor() function that was connected with other class

            // all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}