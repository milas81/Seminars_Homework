/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.Write("\n");
    }
}

double[] AverageSummOfColumns (int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            summ += inArray[j, i];
        }
        result[i] = summ / inArray.GetLength(0);
    }
    return result;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int colomns = int.Parse(Console.ReadLine()!);


int[,] arr = GetArray(row, colomns, 0, 100);
PrintArray(arr);
double[] results = AverageSummOfColumns(arr);
Console.WriteLine(String.Join("; ", results));
