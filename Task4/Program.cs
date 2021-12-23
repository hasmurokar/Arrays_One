using System;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("Введите a");
            var min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            var max = int.Parse(Console.ReadLine());
            var array = new int[10];
            var checker = false;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
                if (array[i] > 0)
                {
                    checker = true;
                }
            }

            Console.WriteLine("Массив до");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            if (checker)
            {
                var minPositive = array.Where(m => m > 0).Min();
                Console.WriteLine("Минимальное положительное число = " + minPositive);
                array[array.Length - 1] = minPositive;
                Console.WriteLine("Массив после");
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Такое число отсутствует");
            }

            Console.ReadLine();
        }
    }
}
