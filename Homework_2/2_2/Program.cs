
// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100, 1000);
// int c = num % 10;
// int a = num / 100;
// Console.WriteLine(num);
// int ac = a*10+c;
// Console.WriteLine(ac);

// String SecondNum(int num)
// {
//     if((-1000 < num && num < -99) ||(num < 1000 && num > 99))
//     return$"{ num }-> {num / 100 *10 + num % 10}";
//     return "The number is not three -digit!";
// }
// int val = int.Parse(Console.ReadLine()!);
// string result = SecondNum(val);
// Console.WriteLine(result);


void NumRendom()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"{num} -> {num / 100}{num % 10}");
}
NumRendom();