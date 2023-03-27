// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.


// string Binary(int num)
// {
//     string res = "";

//     while (num > 0)
//     {
//         res = num % 2 + res;
//         num /= 2;
//     }
//     return res;
// }

// // 12 - 1100, 4 - 100, 45 - 101101
// int n = int.Parse(Console.ReadLine()!);
// string result = Binary(n);
// Console.WriteLine(result);

int num = GetUserNumber("number");
	Console.WriteLine(MakeBinary(num));
	
	int GetUserNumber(string name)
	{
	    int number = 0;
	    Console.Write($"Please enter {name}: ");
	    number = int.Parse(Console.ReadLine()!);
	    return number;
	}
	
	string MakeBinary(int number)
	{
	    string binary = "";
	
	    while (number > 0)
	    {
	        binary = number%2 + binary;
	        number /= 2;
	    }
	    return binary;
	}