// Задача 3: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
 Random rand = new Random();
        int[] arr = new int[8];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 2);
        }

        Console.WriteLine(string.Join(",", arr));

//  В данном примере мы создаем объект класса Random, затем создаем массив arr из 8 элементов
// и заполняем его случайными нулями и единицами в цикле for.
// Затем мы выводим элементы массива на консоль с помощью метода string.Join.
// Метод string.Join в C# объединяет все элементы массива в одну строку с использованием указанного разделителя.

// Синтаксис метода string.Join выглядит следующим образом:
// public static string Join(string separator, params object[] values);

// separator - строка-разделитель, которая будет использоваться для разделения элементов массива.
// values - массив объектов, элементы которого будут объединены в одну строку.
// Пример использования метода string.Join:
// string[] words = {"hello", "world", "this", "is", "a", "sentence"};
// string sentence = string.Join(" ", words);
// Console.WriteLine(sentence);

// В данном примере создается массив строк words и с помощью метода string.Join 
// объединяются все элементы массива в одну строку sentence с разделителем пробелом. 
// Результатом выполнения программы будет строка: "hello world this is a sentence".

// Также, в качестве разделителя можно использовать любой символ или строку, например:
// string[] fruits = {"apple", "banana", "orange"};
// string result = string.Join(", ", fruits);
// Console.WriteLine(result);
