// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

void Kub(int n)
{
    if(n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{i*i*i}");
            if (i !=n)
            {
                Console.Write(", ");
            }
        }
    }
    else
    {
        for (int i = -1; i >= n; i--)
        {
            Console.Write($"{i*i*i}");
            if (i !=n)
            {
                Console.Write(", ");
            }
        }
    }
}

Console.Clear();
Console.Write("Input the number: ");
int N = int.Parse(Console.ReadLine()!);

Kub(N);

