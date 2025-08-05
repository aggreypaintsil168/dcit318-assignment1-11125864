using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter side A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter side B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter side C: ");
            int c = int.Parse(Console.ReadLine());

            // Check if sides are positive
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Error: All sides must be positive integers.");
                return;
            }

            // Check triangle inequality theorem
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Error: The given sides do not form a valid triangle.");
                return;
            }

            // Determine triangle type
            if (a == b && b == c)
                Console.WriteLine("This is an Equilateral Triangle");
            else if (a == b || b == c || a == c)
                Console.WriteLine("This is an Isosceles Triangle");
            else
                Console.WriteLine("This is a Scalene Triangle");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integer values for all sides.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: One or more values entered are too large.");
        }
    }
}
