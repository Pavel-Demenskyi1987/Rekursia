/*Задание 2. Работа в сессионных залах
Семинар 7. Рекурсия
Предварительно обсудить компоненты рекурсии
Инструктаж по работе в залах
20 мин
Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
Указание
Использовать рекурсию. Не использовать цикл.
Пример
N=5 => 1 2 3 4 5*/

using System;

public class Task_03
{
    static public void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ShowDigits(num));
    }

    static public string ShowDigits( int num)
    {
        if( num == 0)
            return " ";
        return  ShowDigits(num - 1) + $"\t{num}";

    }

}