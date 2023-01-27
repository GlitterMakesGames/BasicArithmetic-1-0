/*
 * Week 2 Assignment
 * Variables & Basic Arithmetic
 * Author: Delaina Hardwick
 * Date: January 27, 2023
 */

class MathTest
{
    static void Main(string[] args)
    {
        int myVar = 1;
        string userInput = "";

        Console.Write("Please enter the integer you would like to use: ");
        userInput = Console.ReadLine();

        Console.Write("\n");
        if (userInput == "")
        {
            Console.WriteLine("No input detected. A default value of 1 will be used.");
            calculate(myVar * 1.0);
        }
        else
        {
            try
            {
                myVar = int.Parse(userInput);
                Console.WriteLine("Success! You have chosen a value of " + myVar);
                calculate(myVar * 1.0);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid Input. A default value of 1 will be used.");
                calculate(myVar * 1.0);
            }
        }

        //WARNING: This method uses INTEGER MATH. Results will be innaccurate!
        //I *would* fix this, but the assignment instructions clearly show the use of nondecimal numerals in the operations. So too bad :P
        void calculate(double operand)
        {
            Console.WriteLine("-1 + 4 * " + operand + " = " + (-1 + 4 * operand));
            Console.WriteLine("(35 + 5) % " + operand + " = " + ((35 + 5) % operand));
            Console.WriteLine("14 + -4 * 6 / 12 = " + (14 + -4 * 6 / 12));
            Console.WriteLine("2 + 12 / 6 * 1 - " + operand + " % 2 = " + (2 + 12 / 6 * 1 - operand % 2));
            if ((operand*operand < 10))
            {
                Console.WriteLine("myVar is less than 4.");
            }
            else
            {
                Console.WriteLine("myVar is greater than 4.");
            }
        }
    }
}