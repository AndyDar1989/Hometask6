/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/

Console.Write("Enter number B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number K1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number K2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

void CrossPoint(double xa, double ya, double xb, double yb)
{
    double xc = (xb-xa)/(ya-yb);
    double yc = (yb-ya)+xc+(xb-xa);
    Console.WriteLine($"{xc}; {yc}");
}
CrossPoint(b1,k1,b2,k2);

