/* Задача №1
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.*/

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
}


/*Задача №2*/