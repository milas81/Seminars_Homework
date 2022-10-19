//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на
//нечётных позициях. [3, 7, 23, 12] -> 19             [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetSummOdd(int[] numArray)
{
    int Summ = 0;
    for (int i = 0; i < numArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            Summ = Summ + numArray[i];
        }

    }
    return Summ;
}


Console.Clear();
int[] array = GetArray(4, -100, 100);
Console.WriteLine(String.Join(", ", array));
Console.Write($"Сумма нечетных элементов массиве {GetSummOdd(array)}.");