﻿// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру дня недели");
int n = int.Parse(Console.ReadLine()!);
if (n >= 1 && n <= 7)
{
    if(n== 6 | n==7)
    {
        Console.WriteLine("Выходной день");

    }
    else
    {
        Console.WriteLine(" Рабочий день");
                    
                
    }
}