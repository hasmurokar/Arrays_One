using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 5;
            var array = new int[length];
            var newArray = new int[length];
            var count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите целое число " + (i + 1));
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] == 0)
                {
                    count++;
                }

            }

            Console.WriteLine("Массив до");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < count; i++)
            {
                if (array[i] == 0)
                {
                    newArray[i] = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    newArray[count] = array[i];
                    count++;
                }
            }

            Console.WriteLine("Массив после");
            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
