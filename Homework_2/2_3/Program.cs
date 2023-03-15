// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// ;
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);

// if (n < -99 || n > 99)
// {
//     Console.WriteLine($"Третья цифра = {n.ToString()[2]}");
// }
// else
// {
//     Console.WriteLine("Нет третьей цифры");
// }

void ThirdNum(int num)
{
    
     Console.Write($"{num} -> ");
    if(num < 100)
    {
        Console.WriteLine("The number is not three -digit!");
        return;
    }
    while(num > 999) num /= 10;
    Console.WriteLine(num % 10);
}
int val = int.Parse(Console.ReadLine()!);
ThirdNum(val);





