namespace areaofshape;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("which shape would you like to calculate? ");
        string shape = Console.ReadLine();


        switch (shape)
        {
            case "square":
            {
                Console.WriteLine("Enter side length of a square: ");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"The area of square is {squareArea(side)}");
                break;
            }

            case "rectangle":
            {
                Console.WriteLine("Enter length of a rectangle: ");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter width of a rectangle: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine($"The area of a rectangle is {rectangleArea(length, width)}");
                break;
            }

            case "triangle":
            {
                Console.WriteLine("Enter base length of a triangle: ");
                double baseLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter width of a triangle: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine($"The area of a triangle is {triangleArea(baseLength, width)}");
                break;
            }
            


            case "circle":
            {
                Console.WriteLine("Enter radius of a circle: ");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"The area of a circle is {circleArea(radius)}");
                break;

            }
                default:
            {
                Console.WriteLine("Unacceptable shape for calculation, try again");
                break;
            }
        
    }


}

    


        //square method

        public static double squareArea(double side)
        {

            return side * side;

        }
        
        //rectangle method

        public static double rectangleArea(double length, double width)
        {
            return length * width;
        }
        
        //triangle method

        public static double triangleArea(double baseLength, double width)
        {
            return baseLength * width / 2;
        }
        
        //circle method

        public static double circleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

    }
