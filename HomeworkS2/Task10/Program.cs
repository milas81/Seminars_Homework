// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает
// вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Input the three-digit Number: ");
int num = int.Parse(Console.ReadLine()!);
if (num >= 100 && num < 1000 || num <= - 100 && num > - 1000)
{
    int a1 = num % 100;
    int a2 = num / 10;
    int a3 = a2 % 10;
    if(a3 < 0) 
    {
        a3  = -a3;
    }
    Console.WriteLine($"{num} -> {a3}");
}
else
{
    Console.WriteLine("Input positive the three-digit Number!");
}

