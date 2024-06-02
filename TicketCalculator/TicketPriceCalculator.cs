using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment1_10982383
{
    class TicketPriceCalculator
    {
        static void Main()
        {
            // Prompt the user to enter their age
            Console.Write("Please enter your age: ");

            int age = Convert.ToInt32(Console.ReadLine());

            int ticketPrice;
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7;
            }
            else
            {
                ticketPrice = 10;
            }

            // Display the ticket price
            Console.WriteLine("Your ticket price is: GHC" + ticketPrice);
        }
    }
}

