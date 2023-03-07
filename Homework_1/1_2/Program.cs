// Задача 2: Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("please enter number n1: ");
int n1 = int.Parse(Console.ReadLine()!);

Console.Write("please enter number n2: ");
int n2 = int.Parse(Console.ReadLine()!);

Console.Write("please enter number n2: ");
int n3 = int.Parse(Console.ReadLine()!);
if(n1 > n2)
{
    if(n1 > n3)
    {
         Console.Write("maximum num:" + n1);
    }
    else
    {
        Console.Write("maximum num:" + n3);
    }
   
}
else if(n2 > n3)
{
    Console.Write("maximum num:" + n2);
}
else
{
      Console.Write("maximum num:" + n3);
}


