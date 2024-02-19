using System;

namespace Lab5
{
    class Program
    {
        //main class to test code 
        static void Main()
        {
            try
            {
                //Working Radius because its > than 0
                Circle circle1 = new Circle(3);
                Console.WriteLine(circle1);
                //Exception 1
                Circle circle2 = new Circle(-12);
                Console.WriteLine(circle2);
                //Exception 2
                Circle circle3 = new Circle(0);
                Console.WriteLine(circle3);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}