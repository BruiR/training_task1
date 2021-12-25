/*
 Задание 3. При старте приложение запрашивает у пользователя количество элементов в числовом массиве (минимум – два),
а затем в цикле – сами элементы (типа int). После ввода элементов приложение распечатывает исходный массив и выводит сумму элементов массива,
расположенных между наименьшим элементом массива (самым левым, если их несколько) и наибольшим элементом (самым правым, если их несколько).
Разработать консольное приложение, реализующее указанный функционал.
Пример: массив [1,  3,  5,  1,  0,  3,  0,  1]. Сумма нужных элементов = 5 + 1 + 0 = 6.
Примечание 1: корректность длины массива можно не контролировать.
Примечание 2: наименьший и наибольший элементы включаются в сумму.
 */

using System;

namespace Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count: ");
            int count = int.Parse(Console.ReadLine());
            int[] digitsArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{i+1} element =");
                digitsArray[i] = int.Parse(Console.ReadLine());
            }
            int max = digitsArray[0];
            int maxIndex = 0;
            int min = digitsArray[0];
            int minIndex = 0;
            Console.Write("Array: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{digitsArray[i]}, ");
                if (min > digitsArray[i])
                {
                    min = digitsArray[i];
                    minIndex = i;
                }
                if (max <= digitsArray[i])
                {
                    max = digitsArray[i];
                    maxIndex = i;
                }
            }

            int firstIndex, lastIndex;
            if (maxIndex > minIndex) 
            {
                firstIndex = minIndex;
                lastIndex = maxIndex;
            }
            else
            {
                firstIndex = maxIndex;
                lastIndex = minIndex;
            }
            int sum = 0;
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                sum += digitsArray[i];
            }
            Console.WriteLine("\nsum=" + sum);
        }
    }
}
