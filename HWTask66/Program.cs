// 66// Задайте значения M N. Напишите программу, которая найдет сумму натуральных элементов
// в промежутке
int ReadLine(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()??"");
}

int SumDiapazon(int m, int n)
{
    if(m-1==n)return 0;
    else return m+SumDiapazon(m+1, n);
}

int m=ReadLine("Введите число m: ");
int n=ReadLine("Введите число n: ");
Console.WriteLine(SumDiapazon(m, n));
