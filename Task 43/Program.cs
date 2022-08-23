/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


void CrossPoint(double f1, double f2, double s1, double s2)
{
    double x = (s1 - f1) / (f2 - s2);
    double y = s2 * x + s1;
    Console.WriteLine($"Coordinates of the cross-point of two lines -> ({x}; {y})");
}

Console.Write("Enter number B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number K1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number K2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
CrossPoint(b1, k1, b2, k2);


