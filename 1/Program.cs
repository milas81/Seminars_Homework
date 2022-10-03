//Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго
Console.Clear();
Console.WriteLine ("Input  number1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Input  number2: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 / number2 == number2)
{
    Console.WriteLine($"The Number1 is a squares of the Number2");
}
else {
    Console.WriteLine($"The Number1 is not a squares of the Number2");
}
