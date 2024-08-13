using System.Text.RegularExpressions;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunProgram();
        }

        static void RunProgram()
        {
            bool programRunning = true;
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            do
            {
                string? userInput1 = "";
                string? userInput2 = "";
                double cleanUserInput1;
                double cleanUserInput2;
                double result = 0;

                Console.Write("Type in your first numeric value:\n");          // Ask for first value
                userInput1 = Console.ReadLine();

                while (!double.TryParse(userInput1, out cleanUserInput1))  // Check if first value is a number
                {
                    Console.Write("Please type in a numeric value:\n");
                    userInput1 = Console.ReadLine();
                }

                Console.Write("Type in your second numeric value\n");         // Ask for second value
                userInput2 = Console.ReadLine();

                while (!double.TryParse(userInput2, out cleanUserInput2))  // Check if second value is a number
                {
                    Console.Write("Please type in a numeric value\n");
                    userInput2 = Console.ReadLine();
                }

                // Ask for the operator
                Console.WriteLine("Choose an operator from the following list:\n");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("\n\tYour option? \n");
                string? operation = Console.ReadLine();

                if (operation == null || !Regex.IsMatch(operation, "[a|s|m|d]"))
                {
                    Console.WriteLine("Error, unrecognized operator.\n");
                }
                else
                {
                    try
                    {
                        
                        switch (operation)
                        {
                            case "a": // Addition

                                result = Addition(cleanUserInput1, cleanUserInput2);
                                break;

                            case "s": // Subtraction

                                result = Subtraction(cleanUserInput1, cleanUserInput2);
                                break;

                            case "m": // Multiplication

                                result = Multiplication(cleanUserInput1, cleanUserInput2);
                                break;

                            case "d": // Division

                                // Ask the user to enter a non-zero divisor.
                                if (cleanUserInput1 != 0 && cleanUserInput2 != 0)
                                {
                                    result = Division(cleanUserInput1, cleanUserInput2);
                                }
                                else
                                {
                                    Console.WriteLine("Cannot divide by zero");
                                }
                                break;

                            // Return text for an incorrect option entry.
                            default:

                                break;

                        }


                        if (Double.IsNaN(result))
                        {
                            Console.WriteLine("This operation will result in a mathematical error.\n");
                        }
                        else
                        {
                            Console.WriteLine("Your result: {0:0.##}\n", result);
                        }
                    }
                    catch (Exception whoopsie)
                    {
                        Console.WriteLine("An exception occured while trying to do the operation.\nDetails: " + whoopsie.Message);
                    }
                }
                Console.WriteLine("------------------------\n");

                Console.Write("Press 'x' and Enter to close the app, or press any other key to continue.\n");
                if(Console.ReadLine()== "x")
                {
                    programRunning = false;
                }

            } while (programRunning);
        }


        static double Addition(double firstValue, double secondValue)
        {
            
            
            return firstValue + secondValue;
        }



        static double Subtraction(double firstValue, double secondValue)
        {


            return firstValue - secondValue;
        }
        
        
        
        static double Multiplication(double firstValue, double secondValue)
        {


            return firstValue * secondValue;
        }

        
        
        static double Division(double firstValue, double secondValue)
        {
            if (firstValue == 0 || secondValue == 0) // Extra input validation
            {
                Console.WriteLine("Division by zero error");
                return double.NaN;
            }
            else
            {
                return firstValue / secondValue; 
            }
        }
    }
}