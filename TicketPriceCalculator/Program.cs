using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");

        try
        {
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Error: Age cannot be negative.");
            }
            else if (age <= 12 || age >= 65)
            {
                Console.WriteLine("Ticket Price: GHC7");
            }
            else
            {
                Console.WriteLine("Ticket Price: GHC10");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number you entered is too large.");
        }
    }
}
