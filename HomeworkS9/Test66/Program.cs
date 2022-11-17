// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

int GetSumm (int start, int end)
{
    //int summ = 0;
    if (start == end)
    {
        return end;
    }
    return start + GetSumm(start + 1, end);
}

Console.Clear();
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
if (m > n)
{
    Console.WriteLine("Введен неправильный промежуток чисел");
}
else Console.WriteLine($"Сумма чисел в промежутке {m} и {n} равна: {GetSumm(m, n)}.");