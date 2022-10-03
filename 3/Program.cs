//Напишите программу, которая будет выдавать название дня недели по заданному номеру:
//3 --Среда; 5 -- Пятница

Console.Clear();
Console.WriteLine ("Input day number: ");
int number = int.Parse(Console.ReadLine()!);
string[] days = new string[] {"Mon","Tue","Wed","Thu","Fri","Sat","Sun"};
if (number >= 1 && number <= 7)
{
    Console.WriteLine($"Day of the week: {days[number - 1]}");
}
else {
    Console.WriteLine("ERROR");
}

