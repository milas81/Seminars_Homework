﻿// Задайте значение N. Напищите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

string GetPrint(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return start + " " + GetPrint(start -1, end);
}

Console.Clear();
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(GetPrint(n, m));
