// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел:");
        int m = int.Parse(Console.ReadLine()); // считываем количество чисел

        int count = 0; // переменная для хранения количества чисел, больших 0

        for (int i = 0; i < m; i++)
        { // цикл для считывания чисел и подсчёта количества положительных чисел
            Console.WriteLine($"Введите число {i + 1}:");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел, больших 0: {count}");
    }
}


