// Задача 2: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine()!);
int sum = 0;
foreach (char digit in n.ToString())
{
    int num = int.Parse(digit.ToString());
    sum += num;
}
Console.WriteLine("Sum of digits: " + sum);