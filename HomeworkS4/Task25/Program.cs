// Задача 25: Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень числа В.
// 3, 5 -> 243
// 2, 4 -> 16

int GetResult(int A, int B )
{
    int count = 0;
    int multi = 1;
    while (count < B)
    {
        multi = A * multi;
        count ++;
    }
    return multi;
}

Console.Clear();
Console.Write("Input the number A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Input the number B: ");
int b = int.Parse(Console.ReadLine()!);
if (b < 0)
{
    Console.WriteLine("ERROR");
}
else
{
Console.WriteLine(GetResult(a, b));
}


