/*
    Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53    
*/

double Distance(double x1, double y1, double z1, double x2, double y2, double z2){
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;

    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
}

Console.WriteLine("Enter the coordinates of point A.");
Console.Write("x = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z = ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinates of point B.");
Console.Write("x = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z = ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write(Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2));