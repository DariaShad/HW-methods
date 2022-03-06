using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. 
            //Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.

            double X1 = Convert.ToInt32(Console.ReadLine());
            double Y1 = Convert.ToInt32(Console.ReadLine());
            double X2 = Convert.ToInt32(Console.ReadLine());
            double Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Y={(Y2-Y1)/(X2-X1)}X+{-X1*(Y2-Y1)/(X2-X1)+Y1}");
        }
    }
}
