using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string myName;
            int firstNum;
            int secondNum;
            string operation;
            int answer;

            Console.WriteLine("Hello this is my first Calculator in C#: Tell me Your name! ");
            myName = Console.ReadLine();

            Console.WriteLine("Here are a few operations you can use: *, +, -, /, %");



            Console.WriteLine("Hello! " + myName + " Enter your first number.");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your operation");
            operation = Console.ReadLine();

            Console.WriteLine("Ok cool, now enter your second number.");
            secondNum = Convert.ToInt32(Console.ReadLine());

            if (operation == "*" || operation == "x")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + answer);
                Console.WriteLine();

            }
            else if (operation == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + answer);
                Console.WriteLine();

            }
            else if (operation == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + answer);
                Console.WriteLine();

            }
            else if (operation == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + answer);
                Console.WriteLine();

            }
            else if (operation == "%")
            {
                answer = firstNum % secondNum;
                Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + answer);
                Console.WriteLine();

            }



        }
    }
}
