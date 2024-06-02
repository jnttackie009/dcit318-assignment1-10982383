using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment1_10982383
{
    class TriangleTypeIdentifier
    {
        static void Main()
        {
            Console.WriteLine("Enter the lengths of the all sides of the triangle:");
            Console.Write("Leagnth of side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Legnth of side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Legnth of  side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            string triangleType = GetTriangleType(side1, side2, side3);
            Console.WriteLine($"The triangle is {triangleType}."); // Interpolation
        }

        static string GetTriangleType(double side1, double side2, double side3)
        {
            if ((side1 +side2 > side3) && (side1 + side3 > side2) && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    return "Equilateral";
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    return "Isosceles";
                }
                else
                {
                    return "Scalene";
                }
            }
            else
            {
                return "Invalid shape";
            }
        }
    }
}
