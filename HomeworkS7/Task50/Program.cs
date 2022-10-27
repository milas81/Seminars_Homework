/*Напишите программу, которая на вход принимает число и возвращает индексы элемента в двумерном массиве или же указание, 
что такого элемента нет. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] GetArray(int m, int n)
{
    int[,] inArray = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 100);
        }
    return inArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int [] FindNumb(int[,] inArray, int x)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == x)
            return new int[]{i, j};        
        }
        
    }
    return null;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int colomns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, colomns);
PrintArray(array);
Console.Write("Введите искомое целое число в диапазоне от 0 до 100: ");
int num = int.Parse(Console.ReadLine()!);

int [] result = FindNumb(array, num);
if(result == null)
{
    Console.WriteLine("Введенного числа нет в массиве.");
}
else 
{
    Console.WriteLine($"Введенное число {num} найдено в массиве в позиции [{result[1]},{result[0]}]");
}


