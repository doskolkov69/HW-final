// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

Console.Write("Enter First Number:");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter First Number:");
int N = Convert.ToInt32(Console.ReadLine());
void ShowNumbers (int start, int end)
{
    // Base
    if(start == end)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumbers(start +1, end);
}

ShowNumbers(M,N);