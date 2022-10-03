// Напишите программу, которая на вход принимает трехзначное число, а на выходе показывает последнюю цифру данного числа

Console.Clear();
Console.WriteLine("Put a three-digit number:");
int number = int.Parse(Console.ReadLine()!);
if (number > 99 && number < 1000)
{
Console.WriteLine(number % 10);
}
else Console.WriteLine("ERROR");

