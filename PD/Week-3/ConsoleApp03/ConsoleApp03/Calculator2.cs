using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp03
{
    internal class Calculator2
    {
        public float num1;
        public float num2;

        public Calculator2(float num1, float num2)
        {
            this.num1 = num1;
            this.num2 = num2;

        }
        public float Addition()
        {
            return num1 + num2;

        }
        public float Subtraction()
        {

            return num1 - num2;

        }
        public float Multiplication()
        {

            return num1 * num2;

        }
        public float Division()
        {
            return num1 / num2;

        }
        public float Modulo()
        {
            return num1 % num2;
        }
        public double SquareRoot() 
        { double num = Math.Sqrt((double)(num1));
            return num;
        }
        public double powerOfNumbers() 
        {
            double  num=Math.Pow((double)(num1), (double)(num2));
            return num;
        }
        public double takingLog() 
        {
            double num = Math.Log(num1, num2);
            return num;
        }
        public double Sine()
        { 
            double num= Math.Sin((double)(num1));
            return num;
        }
        public double Cosecant() 
        { 
            double num=Math.Cos((double)(num1));
            return num;
        }
        public double Tangent() 
        { 
            double num= Math.Tan((double)(num1));
            return num;
        }
    }
}
