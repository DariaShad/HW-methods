using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B^2)/(B-A)
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((5 * A + B ^ 2) / (B - A));
        }
    }
}
