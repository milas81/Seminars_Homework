//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива
// [3 7 22 2 78] -> 76

double[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = double.Parse(nums[i]);
    }
    return res;
}

/*double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble()*(maxValue - minValue) + minValue;
    }
    return res;
}*/

double FindMax(double [] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> max)
        {
            max = array[i];
        } 
    }
    return max;
}

double FindMin(double [] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]< min)
        {
            min = array[i];
        } 
    }
    return min;
}

Console.Clear();
Console.WriteLine("Введите массив вещественных чисел через пробел:");
double[] array = GetArrayFromString(Console.ReadLine());
Console.WriteLine(String.Join("; ", array));
Console.WriteLine(FindMax(array)- FindMin(array));

