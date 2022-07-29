using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0, 200, "Точка А");
            Point point2 = new Point(200, 300, "Точка В");
            Point point3 = new Point(100, 200, "Точка С");
            Point point4 = new Point(600, 700, "Точка В");
            Point point5 = new Point(700, 800, "Точка Е");

            Console.WriteLine(Figure.LengthSide(point2, point1));
            Console.WriteLine(Figure.LengthSide(point3, point2));
            Console.WriteLine(Figure.LengthSide(point4, point3));
            Console.WriteLine(Figure.LengthSide(point5, point4));
            Console.WriteLine(Figure.LengthSide(point1, point5));

            // 3 точки
            Figure figure1 = new Figure(point1, point2, point3);
            // 4 точки
            Figure figure2 = new Figure(point1, point2, point3, point4);
            // 5 точек
            Figure figure3 = new Figure(point1, point2, point3, point4, point5);


            Console.ReadLine();
        }
    }

    public class Point
    {
        int x;
        int y;
        string name;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }

    public class Figure
    {
        public static double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2)));
        }

        public static void PerimeterCalculator()
        {
            
        }

        public Figure(Point A, Point B, Point C)
        {
            double length = LengthSide(A, B) + LengthSide(B, C) + LengthSide(A, C);
            Console.WriteLine("Поздравляем, у Вас треугольник, периметр треугольника - " + length);
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            double length = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A);
            Console.WriteLine("Поздравляем, у Вас четырехугольник, периметр четырехугольника - " + length);
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            double length = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A);
            Console.WriteLine("Поздравляем, у Вас пятиугольник, периметр пятиугольника - " + length);
        }


    }
}
