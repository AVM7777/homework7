/* Задача №1
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.*/

/*
using System.Runtime.Intrinsics.Arm;

System.Console.WriteLine("ВВедите число M: ");
int N = int.Parse(Console.ReadLine());
System.Console.WriteLine("ВВедите число N: ");
int M = int.Parse(Console.ReadLine());

void PrintNaturalNumbers(int N, int M)
{
    if (1 > N || 1 > M || N > M)
    {
        return;
    }
    Console.Write(N + " ");
    PrintNaturalNumbers(N + 1, M);
}
PrintNaturalNumbers(N, M);
{
    if (1 > N || 1 > M || N < M)
    {
        return;
    }
    Console.Write(M + " ");
    PrintNaturalNumbers(M + 1, N);
    /*
}


/*Задача №2*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*/



/*Console.Write("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine());

int result = AckermannFunction(m, n);
Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно: {result}");


static int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

/*
Задача №3 
Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.*/

int[] аrray = { 1, 2, 5, 0, 10, 34 };

Console.WriteLine();
PrintArrayReverse(аrray, аrray.Length - 1);

void PrintArrayReverse(int[] arr, int i)
{
    if (i >= 0)
    {
        Console.Write(arr[i] + " ");
        PrintArrayReverse(arr, i - 1);
    }
}