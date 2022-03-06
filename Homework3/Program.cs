using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 строковых(string) значения(A и B). Поменяйте содержимое переменных A и B местами.
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            string temp = A;
            A = B;
            B = temp;
            Console.WriteLine(A);
            Console.WriteLine(B);

        }
    }
}
