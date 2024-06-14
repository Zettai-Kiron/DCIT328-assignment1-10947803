using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade (0-100): ");
            string input = Console.ReadLine();

    
            if (int.TryParse(input, out int grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid grade entered. Please enter a grade between 0 and 100.");
                }
                else
                {
                    char letterGrade;

                    if (grade >= 90)
                    {
                        letterGrade = 'A';
                    }
                    else if (grade >= 80)
                    {
                        letterGrade = 'B';
                    }
                    else if (grade >= 70)
                    {
                        letterGrade = 'C';
                    }
                    else if (grade >= 60)
                    {
                        letterGrade = 'D';
                    }
                    else
                    {
                        letterGrade = 'F';
                    }

                
                    Console.WriteLine($"The letter grade is: {letterGrade}");
                }
            }
            else
            {
                
                Console.WriteLine("Invalid input. Please enter a valid numerical grade.");
            }
        }
    }
}
