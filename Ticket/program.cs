using System;

namespace TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                int ticketPrice;

                if (age <= 12 || age >= 65)
                {
                    ticketPrice = 7;
                }
                else
                {
                    ticketPrice = 10;
                }

                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
