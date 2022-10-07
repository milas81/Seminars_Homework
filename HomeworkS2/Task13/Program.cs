// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Input the Number: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 100  && num > -100)
{
    Console.WriteLine("There is NO third digit!");
}
else
{
    while (num >= 100 || num<= -100 ) 
    {
        if (num < 1000 && num > -1000)
        {
            if(num < 0)
            {
                num = -num;
            }
            Console.WriteLine( $"{num % 10}");
            break;
        }
        else if (num >= 1000  || num <= -1000)
        {
            num = num / 10;           
        }
            
    }   
        
}

