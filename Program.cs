using System;

namespace Ch2Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.6.1 Area of a Circle
            Console.WriteLine("Enter the radius of the circle: ");
            string input = Console.ReadLine();
            double radius = double.Parse(input);
            double circleArea = Math.PI*radius * radius;
            Console.WriteLine($"The area of a circle with radius {radius} is {circleArea} units squared.");

            //2.6.2 More Calculations
            double circumference = Math.PI * radius * 2;
            double diameter = radius * 2;
            Console.WriteLine($"The circumference of a circle with radius {radius} is {circumference}\nand the diameter is {diameter}.");

            //2.6.3 Road Trip!
            Console.WriteLine("What is the miles per gallon of your car: ");
            input = Console.ReadLine();
            double milesPerGallon = double.Parse(input);
            double tripGallons = circumference / milesPerGallon;
            Console.WriteLine($"It will take {tripGallons} gallons to drive around\na circle with {radius} radius.");

        }
    }
}
