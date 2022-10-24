// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int Count(int[] array)
{   
    int num = 0;
    foreach (int el in array)
    {
        if (el > 0)
        {
            num ++;
        }
    }
    return num;
}

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
string input = Console.ReadLine();
int[] numArray = GetArrayFromString(input);
int n = Count(numArray);
Console.WriteLine($"Количество положительных чисел, введенных пользователем равно: {n}");

