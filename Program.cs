using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int a = '0';
            int b = '0';

            //title of the calculator will be shown
            Console.WriteLine("Welcome to the Hypotenuse Calculator!");

            //user inputs the length of side a
            Console.WriteLine("Enter the length of the first side (a): ");
            //collect the user input of side a
            a = Convert.ToInt32(Console.ReadLine());

            //user inputs the length of side b
            Console.WriteLine("Enter the length of the first side (b): ");
            //collect the user input of side b
            b = Convert.ToInt32(Console.ReadLine());

            //calculate the hypotenuse
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            //output the result
            Console.WriteLine($"The length of the hypotenuse is : {c}");

            //the calculator will thank the user
            Console.WriteLine($"Thank you for using the Hypothenuse Calculator!");
        }
    }
}
