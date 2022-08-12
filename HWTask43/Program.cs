// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
//y=k1*x+b1
//y=k2*x+b2
//значения b1 b2 k1 k2 задает пользователь

Console.Write("Введите значение b1: ");
double b1=double.Parse(Console.ReadLine()??"");
Console.Write("Введите значение b2: ");
double b2=double.Parse(Console.ReadLine()??"");
Console.Write("Введите значение k1: ");
double k1=double.Parse(Console.ReadLine()??"");
Console.Write("Введите значение k2: ");
double k2=double.Parse(Console.ReadLine()??"");

double x=(b2-b1)/(k1-k2);
double y=y=k1*x+b1;
Console.WriteLine("x="+x+", y="+y);