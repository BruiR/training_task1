/*
 Задание 2. 10-значный ISBN – это цифровой код, уникально идентифицирующий книгу. 
Он имеет следующий вид: d_1 d_2 d_3 d_4 d_5 d_6 d_7 d_8 d_9 d_10. Цифра d_10 – контрольная. 
Она вычисляется согласно условию, что выражение 〖10d〗_1+9d_2+8d_3+...+ 1d_10
(сумма произведений элементов кода на вес их позиций) должно быть кратно 11.
Создайте программу, которая запрашивает у пользователя строку из 9 символов-цифр (это первые девять цифр ISBN), 
вычисляет контрольную цифру и выводит итоговый ISBN. Корректность ввода пользователя не проверяйте – считайте, что пользователь не допускает ошибок при вводе.
Примечание 1: контрольная «цифра» может быть равна 10. В этом случае для её обозначения используется символ X.
Примечание 2: перевод любого значения a в строку в .NET можно выполнить так: a.ToString().

 */

using System;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first 9 digits of ISBN: ");
            string inputDigits = Console.ReadLine();
            int sum = 0;
            int coefficient = 10;
            for (int i = 0; i < 9; i++)
            {
                sum += coefficient * int.Parse(inputDigits[i].ToString());
                coefficient--;
            }
            int checkDigit = 11 - sum % 11;
            switch (checkDigit)
            {
                case 10:
                    Console.WriteLine(inputDigits[0..9] + "X");
                    break;
                case 11:
                    Console.WriteLine(inputDigits[0..9] + "0");
                    break;
                default:
                    Console.WriteLine(inputDigits[0..9] + checkDigit);
                    break;
            }
        }
    }
}
