﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] agrs)
        {
            // Variables
            string Name;
            char Operator;
            double num1;
            double num2;
            double answer;

            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine("Enter your name before starting: ");
                Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Welcome to the Calculator, " + Name + "!");
                Console.WriteLine("Choose an operator...");
                Console.WriteLine(
                    "1. + (Addition)\n2. - (Subtraction)\n3. * (Multiplication)\n4. / (Division)\n0. Exit"
                );
                Operator = Convert.ToChar(Console.ReadLine());

                switch (Operator)
                {
                    case '1':
                        Console.WriteLine("Enter first number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        answer = num1 + num2;
                        Console.WriteLine("Answer is: " + answer);
                        break;
                    case '2':
                        Console.WriteLine("Enter first number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        answer = num1 - num2;
                        Console.WriteLine("Answer is: " + answer);
                        break;
                    case '3':
                        Console.WriteLine("Enter first number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        answer = num1 * num2;
                        Console.WriteLine("Answer is: " + answer);
                        break;
                    case '4':
                        Console.WriteLine("Enter first number: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        answer = num1 / num2;
                        Console.WriteLine("Answer is: " + answer);
                        break;
                    case '0':
                        Console.WriteLine("Goodbye!");
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Wrong operator");
                        break;
                }
            }
        }
    }
}
