using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }
    public class ProgramMain
    {
        /*public static void Main(string[] args)
        {
            Shape shape1 = new Circle();    
            Shape shape2 = new Rectangle(); 
            // Call the Draw method (which will use runtime polymorphism)
            shape1.Draw(); 
            shape2.Draw(); 
        }*/
    }
}
