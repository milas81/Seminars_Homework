// Заполните спирально массив 4Х4.

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

void FillArrayBySpiral(int[,] Array)
{
    //w - отступ до дальней стенки (верхней или нижней)
    int farDistance = Array.GetLength(0) - 1;
    //l - отступ от ближней стенки (верхней или нижней)
    int nearestDistance = 0;
    int i = 0;
    int j = 0;
    int totalCells = Array.GetLength(0)*Array.GetLength(0);
    // останавливаемся когда заполнили все клеточки
    for (int n = 0; n < totalCells; n++) 
    {
        Array[i,j] = n + 1;
        // переходим на внутренний круг
        if ((i == (nearestDistance + 1)) && (j == nearestDistance)) 
        {
            farDistance--;
            nearestDistance++;
        }
        
        if ((j == farDistance) && (i < farDistance)) 
        {
            //идем вниз
            i++;
            continue;
        } 
        else if ((j < farDistance) && (i == nearestDistance)) 
        {
          //идем вправо
            j++;
            continue;
        } 
        else if ((i == farDistance) && (j > nearestDistance))
        {
            //идем налевo
            j--;
            continue;
        }
        else if ((j == nearestDistance) && (i > nearestDistance)) 
        {
            //идем вверх
            i--;
            continue;
        } 
    }
}

Console.Clear();
Console.Write("Введите сторону квадрата: ");
int size = int.Parse(Console.ReadLine()!);
int[,] arr = new int[size, size];
FillArrayBySpiral(arr);
PrintArray(arr);
