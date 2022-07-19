int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
double lengthAB;

//считывает координаты точек а и б
void readDataOfPoint()
{
    Console.WriteLine("Введите х точки А:");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите y точки А:");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите х точки B:");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите y точки B:");
    coordYPointB = int.Parse(Console.ReadLine());
}
//вычисляет расстояние между точками
void conculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2));
}

readDataOfPoint();
conculateLengthAB();

Console.WriteLine(lengthAB);