using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a grade (0-100): ");
        string? input = Console.ReadLine();

        try
        {
            if (input == null)
            {
                Console.WriteLine("Error: No input provided.");
                return;
            }

            int grade = int.Parse(input);

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Error: Grade must be between 0 and 100.");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("Grade letter: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade Letter: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade Letter: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade Letter: D");
            }
            else
            {
                Console.WriteLine("Grade Letter: F");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid numeric grade.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number entered is too large.");
        }
    }
}
