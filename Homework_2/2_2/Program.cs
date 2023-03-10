
// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
int c = num % 10;
int a = num / 100;
Console.WriteLine(num);
int ac = a*10+c;
Console.WriteLine(ac);