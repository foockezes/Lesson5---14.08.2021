using System;

namespace solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2
            Console.Write("Введите размер массива: ");
            var ArrSize = Convert.ToInt32(Console.ReadLine());
            var arr = new int[ArrSize];
            var sum = 0;
            var q = 0;
            for (; q < arr.Length; q++)
            {
                Console.Write($"ввессти значение индекса {q}: - ");
                arr[q] = Convert.ToInt32(Console.ReadLine());
                sum += arr[q];
            }
            var min = arr[0];
            var max = arr[0];
            for (int i = 1; i < arr.Length; i++, q++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            Console.Write("\n");
            Console.WriteLine($"Максимальное значение массива {max}");
            Console.WriteLine($"Минимальное значение массива {min}");
            Console.WriteLine($"Сумма массива {sum}");
            var MeanValArr = (Convert.ToDouble(sum)) / ArrSize;
            Console.WriteLine($"Среднее арифметическое значение массива {MeanValArr}");
            Console.Write($"Нечётные значение массива: ");
            foreach (int j in arr)
            {
                if (j % 2 == 1) Console.Write($"{j} ");
            }

            // Задание 3
            var a = 0;
            var b = 0;
            Console.Write("\nВведите размер массива: ");
            var ArrV = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[ArrV];
            int[] arr2 = new int[ArrV];


            for (; a < arr1.Length; a++)
            {
                Console.Write($"ввессти значение индекса {a}: - ");
                arr1[a] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = ArrV - 1; i >= 0; i--)
            {
                Console.Write($"{arr1[i]}  ");
            }

            // Задание 4
            Console.Write("\nвведите размер Массива: ");
            int ArrVal = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[ArrVal];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"введите значение индекса {i}:  ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }
            Console.Write("\nРазмер нового массива: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nиндекс с которого начнется индекс массива 2: ");
            int index = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[count];
            for (int i = 0; i < count; i++)
            {
                if (index < ArrVal)
                    array2[i] = array1[index++];
                else array2[i] = 1;
                Console.Write($"{array2[i]}  ");
            }
        }
    }
}
