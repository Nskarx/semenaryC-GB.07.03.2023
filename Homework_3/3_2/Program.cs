// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод координат первой точки
        Console.Write("Введите координату x первой точки: ");
        double x1 = double.Parse(Console.ReadLine()!);
        Console.Write("Введите координату y первой точки: ");
        double y1 = double.Parse(Console.ReadLine()!);
        Console.Write("Введите координату z первой точки: ");
        double z1 = double.Parse(Console.ReadLine()!);

        // Ввод координат второй точки
        Console.Write("Введите координату x второй точки: ");
        double x2 = double.Parse(Console.ReadLine()!);
        Console.Write("Введите координату y второй точки: ");
        double y2 = double.Parse(Console.ReadLine()!);
        Console.Write("Введите координату z второй точки: ");
        double z2 = double.Parse(Console.ReadLine()!);

        // Вычисление расстояния между точками
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        // Вывод результата
        Console.WriteLine($"Расстояние между точками: {distance:F2}");
    }
}