using System;
using System.Data;

namespace Calculator
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Enter your name before starting: ");
            string Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Welcome to the Calculator, " + Name + "!");

            while (true)
            {
                Console.WriteLine("Choose a calculator type...");
                Console.WriteLine("1. Two-number calculator\n2. Standard calculator\n0. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RunTwoNumberCalculator();
                        break;
                    case 2:
                        RunStandardCalculator();
                        break;
                    case 0:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void RunTwoNumberCalculator()
        {
            double num1,
                num2,
                answer;
            char op;

            Console.WriteLine("Two-number calculator");

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operator (+,-,*,/): ");
            op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    answer = num1 + num2;
                    Console.WriteLine("Answer is: " + answer);
                    break;
                case '-':
                    answer = num1 - num2;
                    Console.WriteLine("Answer is: " + answer);
                    break;
                case '*':
                    answer = num1 * num2;
                    Console.WriteLine("Answer is: " + answer);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("∞");
                    }
                    else
                    {
                        answer = num1 / num2;
                        Console.WriteLine("Answer is: " + answer);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }

        static void RunStandardCalculator()
        {
            Console.WriteLine("Standard calculator");

            Console.WriteLine("Enter your problem (e.g. 1+9*1): ");
            string problem = Console.ReadLine();

            // Remove all whitespace from the input string
            problem = problem.Replace(" ", "");

            // Define a table to evaluate arithmetic expressions
            DataTable table = new DataTable();

            try
            {
                // Evaluate the expression using the Compute method of the DataTable object
                object result = table.Compute(problem, "");
                Console.WriteLine("Answer is: " + result);
            }
            catch (SyntaxErrorException ex)
            {
                Console.WriteLine("Invalid syntax: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
