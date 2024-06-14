using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a score (0-100): ");
            string input = Console.ReadLine();

            // Attempt to parse the input to an integer
            if (int.TryParse(input, out int grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid score entered. Please enter a score between 0 and 100.");
                }
                else
                {
                    char Grade;

                    if (grade >= 90)
                    {
                        Grade = 'A';
                    }
                    else if (grade >= 80)
                    {
                        Grade = 'B';
                    }
                    else if (grade >= 70)
                    {
                        Grade = 'C';
                    }
                    else if (grade >= 60)
                    {
                        Grade = 'D';
                    }
                    else
                    {
                        Grade = 'F';
                    }

                    // Display the letter grade
                    Console.WriteLine($"The grade is: {Grade}");
                }
            }
            else
            {
                // Handle invalid input that cannot be parsed to an integer
                Console.WriteLine("Invalid input. Please enter a valid score.");
            }
        }
    }
}
