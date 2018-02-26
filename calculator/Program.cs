using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 0;
            int secondValue = 0;
            string selectedMethod = "";

            string [] method = { "+", "-", "*", "/" };

            double sum = 0.0;

            Console.WriteLine("Please enter an integer!");
            firstValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another integer!");
            secondValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a method! +|-|*|/");
            selectedMethod = Console.ReadLine();

            switch (selectedMethod){

                case "+":
                    sum = firstValue + secondValue;
                    Console.WriteLine(firstValue + " + " + secondValue +" = "+ sum);
                    Console.ReadLine();
                    break;
                case "*":
                    sum = firstValue * secondValue;
                    Console.WriteLine(firstValue + " * " + secondValue +" = "+ sum);
                    Console.ReadLine();
                    break;
                case "-":
                    sum = firstValue - secondValue;
                    Console.WriteLine(firstValue + " - " + secondValue +" = "+ sum);
                    Console.ReadLine();
                    break;
                case "/":
                    sum = firstValue / secondValue;
                    Console.WriteLine(firstValue + " / " + secondValue +" = "+ sum);
                    Console.ReadLine();
                    break;
                default: throw new ArgumentException("Oops! something went wrong!");
            }

        }
    }
}
