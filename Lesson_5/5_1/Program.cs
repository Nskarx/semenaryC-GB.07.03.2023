// Задача 1: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
	}
	
	
	/////////////////////////////////////
	
	void MyFunc (int[] arr){
	    for (int i=0;i<arr.Length;i++){
	        arr[i]*=-1;
	    }
	}
	
	int[] array=MakeArray(count,a,b);
	PrintArray(array);
	Console.WriteLine();
	MyFunc(array);
	PrintArray(array);