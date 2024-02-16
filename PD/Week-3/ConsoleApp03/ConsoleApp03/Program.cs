using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float num1;
            float num2;
            int option = 0;

            Console.Write("Enter the number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the number 2: ");
            num2 = int.Parse(Console.ReadLine());

            Calculator2 c = new Calculator2(num1, num2);
            Console.WriteLine("1.Add.");
            Console.WriteLine("2.Subtract.");
            Console.WriteLine("3.Multiply.");
            Console.WriteLine("4.Division.");
            Console.WriteLine("5.Modulus");
            Console.WriteLine("6.Square root.");
            Console.WriteLine("7.Power");
            Console.WriteLine("8.Log");
            Console.WriteLine("9.Sine");
            Console.WriteLine("10.Cosecant");
            Console.WriteLine("11.Tangent");

            option = chooseOption(option); 
            if (option == 1)
            {
                Console.WriteLine("The addition of numbers is: ");
                Console.WriteLine(c.Addition());
            }
            else if (option == 2)
            {
                Console.WriteLine("The subtraction o numbers is: ");
                Console.Write(c.Subtraction());
            }
            else if (option == 3)
            {
                Console.WriteLine("The multiplication of numbers is: ");
                Console.Write(c.Multiplication());
            }
            else if (option == 4)
            {
                Console.WriteLine("The division is: ");
                Console.Write(c.Division());
            }
            else if (option == 5)
            {
                Console.WriteLine("The modulud of the numbers is: ");
                Console.Write(c.Modulo());
            }
            else if (option == 6)
            {
                Console.WriteLine("The Square Root of num1 is: ");
                Console.Write(c.SquareRoot());
            }
            else if(option == 7)
            {
                Console.WriteLine("The Power of numbers is: ");
                Console.Write(c.powerOfNumbers());
            }
            else if (option == 8)
            {
                Console.WriteLine("The Log of number is: ");
                Console.WriteLine(c.takingLog());
            }
            else if(option == 9)
            {
                Console.WriteLine("The Sine of the number is: ");
                Console.Write(c.Sine());
            }
            else if (option == 10)
            {
                Console.WriteLine("The cos of number is: ");
                Console.Write(c.Cosecant());
            }
            else if (option == 11)
            {
                Console.WriteLine("The tan of number is: ");
                Console.Write(c.Tangent());
            }
            Console.ReadLine();
        }
        static int chooseOption(int option)
        {
            Console.WriteLine("Enter your option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

    }
    
}
