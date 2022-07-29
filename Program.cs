using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите одну сторону прямоугольника");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите вторую сторону прямоугольника");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle1 = new Rectangle(side1, side2);
            Console.WriteLine("Площадь прямоугольника составляет " + rectangle1.Area);
            Console.WriteLine("Периметр прямоугольника составляет " + rectangle1.Perimetr);

            Console.ReadKey();  

        }

    }

    public class Rectangle
    {
        double side1;
        double side2;
        public double Area { get { return AreaCalculator(side1, side2); 
            } 
        }
        public double Perimetr { get { return PerimeterCalculator(side1, side2);
            } }
    
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double PerimeterCalculator(double side1, double side2)
        {
            return (side1 + side2)*2;
        }

        double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;
        }
    }

}
