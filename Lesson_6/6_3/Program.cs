// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.


void Fib(int num)
{
    int n_1 = 0;
    int n_2 = 1;
    
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{n_1} ");
        (n_1, n_2) = (n_2, n_1 + n_2);         
    }
    Console.WriteLine();    
}

int n = int.Parse(Console.ReadLine()!); 
Fib(n);



Console.Write("n=");
	// int n = int.Parse(Console.ReadLine()!);
	/*
	void Fibonacci(int n){
	    int a=0;
	    int b=1;
	    Console.Write($"{a} {b} ");
	
	    for (int i=2;i<n;i++){
	        Console.Write($"{a+b} ");
	        (a,b)=(b,a+b);
	
	    }
	}*/
	
	Fibonacci(n);
	
	void Fibonacci(int n){
	    int a=0;
	    int b=1;
	
	    for (int i=0;i<n;i++){
	        Console.Write($"{a} ");
	        (a,b)=(b,a+b);
	
	    }
	}
