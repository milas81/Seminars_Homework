// Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел

Console.Clear();
Console.WriteLine ("Input  number1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Input  number2: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Input  number3: ");
int number3 = int.Parse(Console.ReadLine()!);

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"The Number1 is greater than the Number2 and Number3");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"The Number2 is greater than the Number1 and Number3");
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine($"The Number3 is greater than the Number1 and Number2");
}
else 
{
    Console.WriteLine($"All three numbers are equal");
}
