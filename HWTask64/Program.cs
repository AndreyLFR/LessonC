//64// Задайте значения M и N.Напишите программу, которая выведет все натуральные числа
// в промежутке от M и N

int ReadLine(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()??"");
}

void NumberPrintUp(int m, int n)
{
    if(m-1==n) return;
    else
    { 
        Console.WriteLine(m+" ");
        NumberPrintUp(m+1, n);
    }
}

void NumberPrintDown(int m, int n)
{
    if(n==m-1) return;
    else
    { 
        NumberPrintDown(m+1, n);
        Console.WriteLine(m+" ");
    }
}

int m=ReadLine("Введите число m: ");
int n=ReadLine("Введите число n: ");
NumberPrintUp(m, n);
Console.Write("\n");
NumberPrintDown(m, n);
