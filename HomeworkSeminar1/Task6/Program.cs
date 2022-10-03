// Напишите программу, которая на вход принимает число и выдает, является ли число четным(делится ли оно на 2 без остатка)

Console.Clear();
Console.WriteLine ("Input  number: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine ("The entered number is even-numbered.");
}
else
{
    Console.WriteLine ("The entered number is odd number.");
}

