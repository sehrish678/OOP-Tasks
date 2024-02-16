using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Calculator
    {
        public float num1;
        public float num2;
       

        public Calculator(float num1,float num2)
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
                return  num1 / num2;
            
        }
        public  float Modulo()
        {
            return num1 % num2;
        }
       
    }
}
