using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var sumNoEven = 0;
            var sumOtr = 0;
            var count = 0;
            var average = 0;
            var array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите целое число " + (i + 1));
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 1)
                {
                    sumNoEven += array[i];
                }
                if (array[i] < 0)
                {
                    sumOtr += array[i];
                    count++;
                }
                
            }

            Console.WriteLine("Массив");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Сумма нечетных эл. = " + sumNoEven);
            if (count > 0)
            {
                average = sumOtr / count;
            }
            
            Console.WriteLine("Ср. ар. отриц. эл. = " + average);

            Console.WriteLine("Значения больше 15");
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > 15)  
                {
                    Console.WriteLine("Индекс " + i);
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && array[i] % 3 == 0)
                {
                    Console.WriteLine("Индекс отриц эл, делящ. на 3 - " + i);
                    break;
                }
            }


            Console.ReadLine();
        }
    }
}
