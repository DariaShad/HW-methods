using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения 
            //стандартного вида, где A*X+B=C.
            Console.WriteLine("Ввведите три числа не равных нулю");

            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int X;
            Console.WriteLine(X = C/A-B);
        }
    }
}
