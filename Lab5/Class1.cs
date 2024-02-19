using System;

//Creating a Circe class
public class Circle
{
    //setting the radius attribute to double.
    private double radius;

    public Circle(double radius)
    {
        SetRadius(radius);
    }
    //Setting radius
    public void SetRadius(double radius)
    {
        //cecking if radius is > than 0
        if (radius > 0)
        {
            this.radius = radius;
        }
        //if not > than 0 throw an exception
        else
        {
            throw new InvalidRadiusException(radius);
        }
    }
    //creating a Tostring method displaying the circles radius infomation
    public override string ToString()
    {
        return $"Circle's radius is: {radius}";
    }
}

// Exception class handling invalid radius
public class InvalidRadiusException : Exception
{
    public double Invalid { get; }

    // Default Constructor
    public InvalidRadiusException() : base("Invalid radius. Radius must be greater than zero.")
    {
        Invalid = 0;
    }

    // Generating an error message
    public InvalidRadiusException(double radius) : base($"Invalid radius: {radius}. Radius must be greater than zero.")
    {
        Invalid = radius;
    }   
}
