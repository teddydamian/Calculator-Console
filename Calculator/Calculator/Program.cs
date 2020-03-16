using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            // User input
            Console.WriteLine("Calculator");
            Console.WriteLine("Choose from following: + - / *");
            string method = Console.ReadLine().ToLower();

            //User output float for decimals
            float output = 0;

            // Condition for + - / *
            if (method == "add" || method == "+" || method == "plus" || method == "sum")
            {
                Console.Write("Enter a number: ");
                int firstNumb = int.Parse(Console.ReadLine());

                Console.Write("Enter a number: ");
                int secondNumb = int.Parse(Console.ReadLine());
                output = Addition(firstNumb, secondNumb);
            }
            else if (method == "minus" || method == "-" || method == "substract" || method == "substraction")
            {
                Console.Write("Enter a number: ");
                int firstNumb = int.Parse(Console.ReadLine());

                Console.Write("Enter a number: ");
                int secondNumb = int.Parse(Console.ReadLine());
                output = Substraction(firstNumb,secondNumb);
            }
            else if (method == "multiply" || method == "*" || method == "multiplication")
            {
                Console.Write("Enter a number: ");
                int firstNumb = int.Parse(Console.ReadLine());

                Console.Write("Enter a number: ");
                int secondNumb = int.Parse(Console.ReadLine());
                output = Multiplication(firstNumb, secondNumb);
            }
            else if (method == "divide" || method == "/" || method == "division")
            {
                Console.Write("Enter a number: ");
                int firstNumb = int.Parse(Console.ReadLine());

                Console.Write("Enter a number: ");
                int secondNumb = int.Parse(Console.ReadLine());
                output = Division(firstNumb, secondNumb);
            }
            else
            {
                Console.WriteLine("Please input a proper operand. \n");
                Main();
            }

            Console.WriteLine("result is : {0}\n", output);
            Main();
        }

        // All methods
        public static int Addition(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public static int Substraction(int number1, int number2)
        {
            int substract = number1 - number2;
            return substract;
        }

        public static int Multiplication(int number1, int number2)
        {
            int multiply = number1 * number2;
            return multiply;
        }

        public static float Division(float number1, float number2)
        {
            float divide = (number1 / number2);
            return divide;
        }
    }
}
