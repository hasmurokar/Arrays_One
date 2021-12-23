using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите целое число " + (i + 1));
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Массив до");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            var min = array.Min();
            var max = array.Max();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max)
                {
                    array[i] = 0;
                }
            }

            Console.WriteLine("Массив после");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
