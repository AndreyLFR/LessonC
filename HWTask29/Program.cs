// Напишите программу, которая задает массив из 8 элементов и выводит их на экран
//*ввести с клавиатуры длину массива и диапазон элементов
//решение только задачи со *

System.Random numberSintezator=new Random();
Console.Write("Введите длину массива: ");
int arrLength=int.Parse(Console.ReadLine()??"");
Console.Write("Введите нижнюю границу диапазона элементов: ");
int downNumber=int.Parse(Console.ReadLine()??"");
Console.Write("Введите верхнюю границу диапазона элементов: ");
int upNumber=int.Parse(Console.ReadLine()??"");

void GenArray()
{
    int i=0;
    Console.Write("[");
    while(i<arrLength-1)
    {
        Console.Write(numberSintezator.Next(downNumber,upNumber));
        Console.Write(",");
        i++;
    }
    Console.Write(numberSintezator.Next(downNumber,upNumber));
    Console.Write("]");
}

GenArray();