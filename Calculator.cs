using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    public class Program
    {
        /*public static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine($"Add 2 integers: {calc.Add(10, 20)}");    
            Console.WriteLine($"Add 3 integers: {calc.Add(10, 20, 30)}"); 
            Console.WriteLine($"Add 2 doubles: {calc.Add(10.5, 20.3)}");  
        }*/
    }
}
