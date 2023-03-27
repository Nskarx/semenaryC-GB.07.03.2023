// Задача 2: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0
// using System;

// class Program {
//     static void Main(string[] args) {
//         // Создаем генератор случайных чисел
//         Random rand = new Random();

//         // Создаем массив и заполняем его случайными числами
//         int[] arr = new int[10];
//         for (int i = 0; i < arr.Length; i++) {
//             arr[i] = rand.Next(0, 100);
//         }

//         // Находим сумму элементов на нечетных позициях
//         int sum = 0;
//         for (int i = 1; i < arr.Length; i += 2) {
//             sum += arr[i];
//         }

//         // Выводим результат на экран
//         Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
//     }
// }

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)    
        Console.Write($"{arr[i]} ");

    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 1; i < size; i++)    
        arr[i] = new Random().Next(from, to + 1);
    
    return arr;
}

int OddNumSum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i += 2)    
        count += arr[i];
    
    return count;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Console.WriteLine(OddNumSum(mass));
