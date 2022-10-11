// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
double result;
result = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
return result;
}

Console.Clear();
Console.WriteLine("Enter the x coordinates of A: ");
int ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the y coordinates of A: ");
int ay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the z coordinates of A: ");
int az = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the x coordinates of B: ");
int bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the y coordinates of B: ");
int by = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the z coordinates of B: ");
int bz = int.Parse(Console.ReadLine()!);


Console.Write($"the length of segment AB is {Dist(ax, ay, az, bx, by, bz):f2}");