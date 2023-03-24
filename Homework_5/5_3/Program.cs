// Задача 3: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3, 7, 22, 2, 78] -> 76
using System;

class Program {
    static void Main(string[] args) {
        double[] arr = { 3.0, 7.0, 22.0, 2.0, 78.0 }; // инициализация массива
        double max = arr[0], min = arr[0];

        // поиск максимального и минимального элементов
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > max) {
                max = arr[i];
            }
            if (arr[i] < min) {
                min = arr[i];
            }
        }

        double diff = max - min;
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
    }
}
