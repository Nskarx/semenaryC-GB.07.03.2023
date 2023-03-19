// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// string number =  Console.ReadLine();

// void CheckingNumber(string number)
// {
//   if (number[0]==number[4] || number[1]==number[3])
//   {
//     Console.WriteLine($"Число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Число: {number} - не палиндром.");
// }
// if (number!.Length == 5)
// {
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");


    // решение преподователя
     void Pali(int num)
     {
      int num_1_2 = num / 1000;
      int num_5 = num % 10;
      int num_4 =num / 10 % 10;
      if(num_1_2 == num_5 * 10 + num_4)
      Console.WriteLine($"yes, { num} is a palindrome");
      else
      Console.WriteLine($"no, {num} in not palindrome");
     }
     Console.WriteLine("enter a five -digit number");
     int val = int.Parse(Console.ReadLine()!);
     Pali(val);