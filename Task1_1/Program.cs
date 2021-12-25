/*
 Задание 1. При старте приложение запрашивает у пользователя два целых числа a и b 
(считать, что пользователь вводит целые числа без ошибок). Затем приложение выводит все 
целые числа в диапазоне от a (включительно) до b (включительно), которые в своём троичном 
представлении имеют ровно две двойки. Разработать консольное приложение, реализующее указанный функционал.
Примечание: для преобразования строки s в значение типа int используйте метод-функцию int.Parse(s).
 */
using System;

namespace Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            int firstNumber, lastNumber;
            if (a < b)
            {
                firstNumber = a;
                lastNumber = b;
            }
            else
            {
                firstNumber = b;
                lastNumber = a;
            }
                                           

            for (int decimalNumber = firstNumber; decimalNumber <= lastNumber; decimalNumber++)
            {
                int number = decimalNumber;
                string ternaryNumber = "";
                while (number > 0)
                {
                    ternaryNumber = (number % 3) + ternaryNumber;
                    number /= 3;
                }
                int counter = 0;
                foreach (char figure in ternaryNumber)
                {
                    if (figure == '2')
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    Console.WriteLine($"A number in the decimal system = {decimalNumber}  A number in the ternary system = {ternaryNumber}");
                }
            }
        }
    }
}
