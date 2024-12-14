using System;

namespace AbstractionExample
{
    public abstract class NumberChecker
    {
        public abstract void CheckNumber(int number);

        public void DisplayMessage()
        {
            Console.WriteLine("This program checks if a number is Even or Odd.");
        }
    }

    public class EvenOddChecker : NumberChecker
    {
        public override void CheckNumber(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even.");
            }
            else
            {
                Console.WriteLine($"{number} is Odd.");
            }
        }
    }

    public class Program
    {
       /* public static void Main(string[] args)
        {
            NumberChecker checker = new EvenOddChecker();

            checker.DisplayMessage();
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            checker.CheckNumber(number);
        }*/
    }
}
