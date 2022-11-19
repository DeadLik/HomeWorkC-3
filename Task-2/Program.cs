// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A");
Console.Write("Координаты точки x: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Координаты точки y: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Координаты точки z: ");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите координаты точки B");
Console.Write("Координаты точки x: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Координаты точки y: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Координаты точки z: ");
double zb = Convert.ToDouble(Console.ReadLine());

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res1 = (x2 - x1) * (x2 - x1);
    double res2 = (y2 - y1) * (y2 - y1);
    double res3 = (z2 - z1) * (z2 - z1);
    double result = res1 + res2 + res3;
    return Math.Sqrt(result);
}

double distance = Distance(xa, ya, za, xb, yb, zb);

Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));