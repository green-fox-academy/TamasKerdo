using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_08
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            Console.WriteLine("give me two numbers and the operations in this form:\n_operation_ _number_ _number_");
            Console.WriteLine("possible operations: +,-,*,/,%");
            string input = Console.ReadLine();
            string[] array = new string[3];

            array = input.Split( );


            if (array.Length != 3)
            {
                Console.WriteLine("try again!");
            }
            else
            {
                OperationOnNumbers(array);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }





        static void OperationOnNumbers(string[] inputArray)
        {
            float result = 0;
            float operand1;
            float operand2;
            float.TryParse(inputArray[1], out operand1);
            float.TryParse(inputArray[2], out operand2);

            if (inputArray[0] == "+")
            {
                result = operand1 + operand2;

            }
            else if (inputArray[0] == "-")
            {
                result = operand1 - operand2;

            }
            else if (inputArray[0] == "*")
            {
                result = operand1 * operand2;

            }
            else if (inputArray[0] == "/")
            {
                result = operand1 * operand2;

            }
            else if (inputArray[0] == "%")
            {
                result = operand1 % operand2;

            }
            else
            {
                Console.WriteLine("nooooooo, try again!");
            }

            if (result != 0)
            {
                Console.WriteLine("The result is:" + result);
            }
        }
    }
}
