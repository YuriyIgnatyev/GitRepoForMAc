// Разница между минимальной и максимальной Salary
using System;

namespace SalaryExample
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Ведите три числа ");
            var A = Console.ReadLine().Split(' ');
            var C = int.Parse(A[0]);
            var D = int.Parse(A[1]);
            var E = int.Parse(A[2]);
            int min = 1, max = 2;
            //max = Math.Max(E, Math.Max(C, D)); //возвращает максимальное число из a, b, c
            //min = Math.Min(C, Math.Min(D, E)); //возвращает минимальное число из a, b, c

            if (C > D & C > E)
            {
                max = C;
            }
            if (D > C & D > E) 
            {
                max = D; 
            }
            if (E > D & E > C) 
            {
                max = E; 
            }
            if (C < D & C < E)
            {
                min = C;
            }
            if (D < C & D < E)
            {
                min = D;
            }
            if (E < D & E < C)
            {
                min = E;
            }

            Console.WriteLine("Разница между минимальной и максимальной зарплатой составляет " + (max - min));
        }
    } // задача найти в массиве любого размера минимальное или максимальное число без использования Math
} // количество работников не ограничено
// не использовать мин макс
// цикл и иф от 8 строк до ...