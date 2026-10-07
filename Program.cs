using System;

// Нахождение наибольшего общего делителя (НОД) двух целых чисел
//4 5 

namespace Recursion
{
    class Program
    {
        static int Calculate(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return Calculate(b, a % b);
        }

        static void Main()
        {
            Console.WriteLine("Нахождение наибольшего общего делителя двух целых чисел");

            int a = 15, b = 33;

            Console.WriteLine("a = {0}, b = {1}, НОД = {2};", a, b, Calculate(a, b));
            Console.WriteLine("a = {0}, b = {1}, НОД = {2};", a, b, Calculate2(a, b));

            Console.ReadKey();
        }

        #region Второй вариант решения

        static int Calculate2(int a, int b)
        {
            //int c = a;
            //while (c % b != 0)
            //{
            //    c = a % b;

            //}

            //return b;
            int c = 0;
            while (b != 0)
            {
                c = (a = b);
                b = a % (a = b);
            }
            return a;
        }
        
        #endregion
    }
}
