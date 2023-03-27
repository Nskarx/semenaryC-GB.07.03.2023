// Задача 1: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] arr = new int[4]; // создаем массив на 4 элемента

//         Random rnd = new Random(); // создаем объект для генерации случайных чисел

//         // заполняем массив случайными положительными трехзначными числами
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = rnd.Next(100, 1000); // генерируем число от 100 до 999
//             Console.Write(arr[i] + " "); // выводим элементы массива на экран
//         }

//         // подсчет количества четных чисел в массиве
//         int evenCount = 0;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[i] % 2 == 0) // если число четное
//             {
//                 evenCount++; // увеличиваем счетчик четных чисел
//             }
//         }

//         Console.WriteLine("\nКоличество четных чисел в массиве: " + evenCount);
        
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

    for (int i = 0; i < size; i++)    
        arr[i] = new Random().Next(from, to + 1);
    
    return arr;
}

int EvenNum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)        
            count += 1;                
    }
    return count;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Console.WriteLine(EvenNum(mass));