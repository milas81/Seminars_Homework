// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные чисоа от 1 до N.

Console.Clear();
Console.WriteLine("Input  number: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 1)
{
    Console.Write("Numbers: ");
    int y = 1;
    while (y <= number)
    {
        if (y % 2 == 0)
        {
            Console.Write($"{y} ");
        }
        y++;
    }
}
else
{
    Console.WriteLine("The number must be greater or equal than 1");
}
