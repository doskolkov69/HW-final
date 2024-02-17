// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // Задача 1: Задайте значения M и N. Напишите программу, 
// // которая выведет все натуральные числа в промежутке от M до N.
// //  Использовать рекурсию, не использовать циклы.

// Console.Write("Enter First Number:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter First Number:");
// int N = Convert.ToInt32(Console.ReadLine());
// void ShowNumbers (int start, int end)
// {
//     // Base
//     if(start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     Console.Write(start + " ");
//     ShowNumbers(start +1, end);
// }

// ShowNumbers(M,N);

// Задача 2: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int FindAckerman(int n, int m)
// // A(n, m) => A(0, m); n = 0, 
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     if (m == 0)
//     {
//         return n - 1;
//     }
// }

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

// Задача 3: Задайте произвольный массив.
//  Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] arr = { 1, 2, 5, 0, 10, 34 };
int size = arr.Length;

void ShowReverse(int[] arr, int size)
{
   int j = size - 1;
    if (j == 0)
    {
        Console.Write(arr[j]);
        return;
    }
    Console.Write(arr[j] + " ");
    ShowReverse(arr[j]-1,  size);
    }

void ShowReverse(int v, int size)
{
    throw new NotImplementedException();
}