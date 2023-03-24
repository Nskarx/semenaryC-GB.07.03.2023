// Задача 2: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("РљРѕР»-РІРѕ СЌР»РµРјРµРЅС‚РѕРІ:");
	int count =int.Parse(Console.ReadLine()!);
	Console.Write("РќР°С‡Р°Р»Рѕ РґРёР°РїРѕР·РѕРЅР°:");
	int a =int.Parse(Console.ReadLine()!);
	Console.Write("РљРѕРЅРµС† РґРёР°РїРѕР·РѕРЅР°:");
	int b =int.Parse(Console.ReadLine()!);
	
	int[] MakeArray(int c, int m, int n){
	    int[] array =new int[c];
	
	    for (int i=0;i<array.Length;i++) array[i]=new Random().Next(m,n+1);
	    return array;
	}
	
	void PrintArray(int[] arr){
	    for (int i=0;i<arr.Length;i++) Console.Write($"{arr[i]} ");
	    Console.WriteLine();
	}
	
	int[] array=MakeArray(count, a,b);
	PrintArray(array);
	////////////////////////////////////////////
	
	bool FindNumber (int[] arr, int n){
	
	    for (int i=0;i<arr.Length;i++){
	        if (arr[i]==n){
	            return true;
	        }
	    }
	    return false;
	}
	
	Console.Write("Р’РІРµРґРёС‚Рµ С‡РёСЃР»Рѕ:");
	int n= int.Parse(Console.ReadLine()!);
	
	Console.WriteLine(FindNumber(array,n));