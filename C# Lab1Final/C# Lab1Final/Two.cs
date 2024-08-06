using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab1Final
{
    using System;

    class Two
    {
        static void Main()
        {
            Console.WriteLine("Enter three integers to calculate their sum:");

            Console.Write("Enter the first integer: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the third integer: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber;


            Console.WriteLine($"\nThe sum of {firstNumber}, {secondNumber}, and {thirdNumber} is: {sum}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}
