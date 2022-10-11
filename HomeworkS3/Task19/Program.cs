// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReverseNumber(int number)
{
    int n = 0;
    int temp = number;
    while ( temp > 0)
    {
        n = 10 * n + temp % 10;
        temp = temp / 10;
    }
 
    return n;
}

bool IsPalindrom(int x)
{
    bool result = false;
    if (ReverseNumber(x) == x)
    {
        result = true;
    }
    return result;
}

bool IsFivedigit (int x)
{
    bool result = false;
    if (x > 9999 && x <100000)
    {
        result = true;
    }
    return result;
}


Console.Clear();
Console.WriteLine("Input a 5-digit number");

int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    num = -num;
}

if (IsFivedigit(num))
{
    if(IsPalindrom(num))
    {
        Console.WriteLine("The number is PALINDROM");
    }
    else 
    {
        Console.WriteLine("The number is NOT PALINDROM");
    }
}
else
{
    Console.WriteLine("The input number is NOT 5-digit!!!");
}

