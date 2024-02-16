using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            int option=0;

            Console.Write("Enter the number 1: ");
            num1 = int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the number 2: ");
            num2= int.Parse( Console.ReadLine());


            Calculator c = new Calculator(num1, num2);
            Console.WriteLine("1.Add.");
            Console.WriteLine("2.Subtract.");
            Console.WriteLine("3.Multiply.");
            Console.WriteLine("4.Division.");
            Console.WriteLine("5.Modulus");
            
           
            option = chooseOption(option);

            if (option==1)
            {
                Console.WriteLine("The addition of numbers is: ");
                Console.WriteLine(c.Addition());
            }
            else if(option == 2)
            {
                Console.WriteLine("The subtraction o numbers is: ");
                Console.Write(c.Subtraction());
            }
            else if(option == 3)
            {
                Console.WriteLine("The multiplication of numbers is: ");
                Console.Write(c.Multiplication());
            }
            else if(option == 4)
            {
                Console.WriteLine("The division is: ");
                Console.Write(c.Division());
            }
            else if(option==5) 
            { 
                Console.WriteLine("The modulud of the numbers is: ");
                Console.Write(c.Modulo());
            }
            
            Console.ReadLine();
        }
        static int chooseOption(int option)
        {
            Console.WriteLine("Enter your option: ");
            option =int.Parse(Console.ReadLine());
            return option;
        }
    }
}
