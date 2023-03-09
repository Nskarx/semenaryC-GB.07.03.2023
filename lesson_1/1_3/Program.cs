// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.Write("N=");
int n = int.Parse(Console.ReadLine()!);

int count = -n;

while (count != n)
{
    Console.WriteLine(count);
    if (n < 0)
    {
        count--;
    }
    else
    {
        count++;
    }

}

// // --------------------------------------- вариант 1

// string s_N = Console.ReadLine()!;
// int N = int.Parse(s_N);
// int m = -N;

// while (m <= N)
// {
//     Console.Write($"{m} ");
//     m += 1;
// }


// // --------------------------------------- вариант 2

// int N = int.Parse(Console.ReadLine()!);
// int m = -N;

// while (m != N)
// {
//     Console.Write($"{m} ");
//     if (N > 0) m += 1;
//     else m -= 1;
// }
// Console.Write($"{m} ");