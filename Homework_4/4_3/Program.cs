// Задача 3: Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

int[] arr = GenerateArray(8);
        PrintArray(arr);
  

    static int[] GenerateArray(int length)
    {
        Random rand = new Random();
        int[] arr = new int[length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(100);
        }

        return arr;
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }