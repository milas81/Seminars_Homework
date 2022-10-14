// Напишите функцию, которая принимает на вход число и выдает сумму цифр в числе:
// 452  ->  11, 82 -> 10, 9012 ->12


int Summ (int number)
{
    int n = 0;
    int temp = number;
    while ( temp > 0)
    {
        n = n + temp % 10;
        temp = temp / 10;
    }
 
    return n;
}


Console.Clear();
Console.WriteLine("Input the number");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    num = -num;
}
Console.WriteLine(Summ(num));


