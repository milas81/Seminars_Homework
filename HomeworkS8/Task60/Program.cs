// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.

int[,,] GetArray(int m, int n, int z, int minValue, int maxValue)
{
    if(maxValue - minValue < m * n * z) 
    {
        return null;
    }
    int[,,] result = new int[m, n, z];
    int[] temp = new int[m*n*z];
    int tempItems = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                result[i, j, k] = GetUniqueRandom(temp, tempItems, minValue, maxValue);
                tempItems = tempItems + 1;
            }
        }
    }
    return result;
}

int GetUniqueRandom(int[] temp, int currentLength, int minValue, int maxValue)
{
    while(true)
    {
        int num = new Random().Next(minValue, maxValue);
        bool isUnique = true;
        for(int i = 0; i < currentLength; i++)
        {
            if(temp[i] == num)
            {
                isUnique = false;
                break;
            }
        }
        if(isUnique)
        {
            temp[currentLength] = num;
            return num;
        }
    }
}

void Print3DArray(int[,,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"[{i}, {j}, {k}]={arr[i,j,k]}; ");                
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


Console.Clear();
Console.WriteLine("Введите размер A трехмерного массива: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер В трехмерного массива: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер C трехмерного массива: ");
int C = int.Parse(Console.ReadLine()!);

int[,,] arr = GetArray(A, B, C, -99, 99);
if(arr == null)
{
    Console.WriteLine("Ошибка. Мы не можем сгенерировать столько уникальных чисел n для заданного массива и диапазона случайных чисел");
}
else
{
    Print3DArray(arr);
}
