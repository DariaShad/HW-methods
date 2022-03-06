using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(A / B);
            Console.WriteLine(A % B);
        }
    }
}
