namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void RunProgram()
        {
            bool programRunning = true;
            Console.WriteLine("");
            Console.ReadLine();
            do
            {

            } while (programRunning);
        }


        static decimal Addition(decimal firstValue, decimal secondValue)
        {
            
            
            return firstValue + secondValue;
        }

        static decimal Subtraction(decimal firstValue, decimal secondValue)
        {


            return firstValue - secondValue;
        }

        static decimal Multiplication(decimal firstValue, decimal secondValue)
        {


            return firstValue * secondValue;
        }

        static decimal Division(decimal firstValue, decimal secondValue)
        {
            if (firstValue == 0 || secondValue == 0)
            {
                return 0;
            }
            else
            {
                return firstValue / secondValue;
            }
        }

        static void CheckInput(string input)
        {

        }
    }
}