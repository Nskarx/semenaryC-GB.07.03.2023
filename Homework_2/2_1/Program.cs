﻿// // Задача 1: Напишите программу, которая принимает на
// // вход трёхзначное число и на выходе показывает вторую
// // цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// Console.Write("Введите трёхзначное число: ");
// int n = int.Parse(Console.ReadLine()!);
//  n = n / 10 % 10;
// Console.WriteLine($"{n}");

String NumSec(int num)
{
    if ((-1000 < num && num < - 100) || (num < 1000 && num > 100) )
    return $"{num / 10 % 10 }";
    return "The number is not three -digit!";
}
Console.WriteLine(NumSec (int.Parse(Console.ReadLine()!)));