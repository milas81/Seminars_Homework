//Напишите программу, которая на вход принимает число
// и выдает его квадрат (число умноженное на само себя).

Console.Clear();
Console.Write("put the number: ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;
Console.WriteLine($"Square of the number {number} is equal to {sqr}");
