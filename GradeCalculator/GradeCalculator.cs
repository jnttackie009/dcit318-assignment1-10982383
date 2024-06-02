using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment1_10982383
{
    public class GradeCalculator
    {
        private int grade;

        // Run the grade through the program
        private string GetGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        // Convert the input of the user from string to to numnerical and check for validity
        public string Conversion(string input)
        {
            // Convert the input to an integer
            int grade;
            bool isValid = int.TryParse(input, out grade);

            // Check if the input is valid
            if (isValid && grade >= 0 && grade <= 100)
            {
                // Determine the letter grade based on the numerical grade
                string letterGrade = GetGrade(grade);

                // Return the corresponding letter grade
                return "You had grade: " + letterGrade;
            }
            else
            {
                // Return an error message if the input is not valid
                return "Invalid input. Please make sure your prompt is a numerical between 0 and 100.";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a numerical grade
            Console.Write("Enter your score (between 0 and 100): ");
            string grade = Console.ReadLine();

            GradeCalculator gradeCalculator = new GradeCalculator();
            string result = gradeCalculator.Conversion(grade);

            Console.WriteLine(result);


        }
    }
}
