// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);

        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int FindMinSummaOfRows(int[,] inArray)
{
    int MinSumm = 0;
    int row = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            summ = summ + inArray[i, j];

        }
        if (i == 0)
        {
            MinSumm = summ;
        }
        else if (summ < MinSumm)
        {
            MinSumm = summ;
            row = i;
        }
    }
    return row +1;
}

Console.Clear();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetArray(row, col, 0, 10);
PrintArray(userArray);
Console.WriteLine($"Строка с наименьшей суммой элементов {FindMinSummaOfRows(userArray)}");
