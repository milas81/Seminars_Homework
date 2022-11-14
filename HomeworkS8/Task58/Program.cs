// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int [,] GetMulMatrix(int[,]matrix1, int[,]matrix2)
{

    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] result = new int[ matrix1.GetLength(0), matrix2.GetLength(1)];

        for(int i = 0; i < matrix1.GetLength(0); i++)
        {
            for(int j =0; j < matrix2.GetLength(1); j++) 
            {
                // j - номер строки первой матрицы
                // i - номер столбца второй
                int itemsCount = matrix1.GetLength(1);
                int sum = 0;
                for(int k = 0; k < itemsCount; k++) 
                {
                    sum = sum + matrix1[j, k] * matrix2[k, i];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }
    return null;
}

Console.Clear();
Console.Write("Введите количество строк в матрице 1:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице 1:");
int col = int.Parse(Console.ReadLine()!);
int[,] userArray1 = GetArray(row, col, 0, 10);
PrintArray(userArray1);

Console.Write("Введите количество строк в матрице 2:");
row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице 2:");
col = int.Parse(Console.ReadLine()!);
int[,] userArray2 = GetArray(row, col, 0, 10);
PrintArray(userArray2);
Console.WriteLine("\nResult:");
int[,] resMatrix = GetMulMatrix(userArray1, userArray2);
if(resMatrix == null)
{
    Console.WriteLine("Ошибка. Несогласованные матрицы. Перемножение невозможно.");
}
else
{
    PrintArray(resMatrix);
}