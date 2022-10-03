// Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();
Console.WriteLine("Input the Number: ");
int N = int.Parse(Console.ReadLine()!);
int x = -N;
while (x <= N)
{
    Console.Write($"{x}; ");
    x++;
}
