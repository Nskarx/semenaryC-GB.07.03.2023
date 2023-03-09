// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите число от 1 до 7:  ");
// int num = int.Parse(Console.ReadLine()!);
// if(num == 1) 
// {
//    Console.Write("понедельник");
// }
// else if(num == 2) 
// {
//    Console.Write("вторник");
 
// }
// else if(num == 3) 
// {
//    Console.Write("Среда");
 
// }
// else if(num == 4) 
// {
//    Console.Write("Четверг");
 
// }
// else if(num == 5) 
// {
//    Console.Write("Пятница");
 
// }
// else if(num == 6) 
// {
//    Console.Write("Суббота");
 
// }

// else if(num == 7) 
// {
//    Console.Write("Воскресенье");
 
// }
// else 
// {
//   Console.WriteLine("Неизвестное число");
// }

string s_a = Console.ReadLine()!;
int a = int.Parse(s_a);

if (a == 1)
{
    Console.WriteLine("Monday");
}
else if (a == 2)
{
    Console.WriteLine("Tuesday");
}
else if (a == 3)
{
    Console.WriteLine("Wednesday");
}
else if (a == 4)
{
    Console.WriteLine("Thursday");
}
else if (a == 5)
{
    Console.WriteLine("Friday");
}
else if (a == 6)
{
    Console.WriteLine("Saturday");
}
else if (a == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Wrong number");
}
