// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Clear();
Console.WriteLine ("Input  number1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Input  number2: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine($"The Number1 is greater than the Number2");
}
else if (number1 == number2)
{
    Console.WriteLine($"The Numbers are equal");
}
else {
    Console.WriteLine($"The Number2 is greater than the Number1");
}

