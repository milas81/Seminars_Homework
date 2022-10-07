// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Enter the day of the week: ");
int num = int.Parse(Console.ReadLine()!);
if (num >= 1 && num < 6)
{
    Console.WriteLine("Entered day is working day");
}
else if (num == 6 || num == 7)
{
    Console.WriteLine("Entered  day is day off");
}
else 
{
    Console.WriteLine("Entered  error");
}
