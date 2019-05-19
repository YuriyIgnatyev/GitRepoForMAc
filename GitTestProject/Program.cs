using System;

namespace GitTestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' '); // string
            var max = 0; // will be rewrited // int.MaxValue; because it dosn't work normally
            var min = 0; // will be rewrited // int.MinValue; because it dosn't work normally
            // var С = int.Parse(array[0]); because we dont use it
            int number;
            int index; // = 0; because we dont use it

            for (index = 0; index < array.Length; index++) // index = index +1) int index = new index []
            {
                number = int.Parse(array[index]); // Создание одномерного массива: целых чисел, необьявленного размера
                //.Parse covert String from [index (arrey)] to int
                if (max < number)
                {
                    max = number;
                }
                if (min > number)
                {
                    min = number;
                }
            }
            Console.WriteLine("Minimum = " + min + "Maximum = " + max);
        }
    }
}
