Console.Clear();
Console.Write("Введите число: ");

int inputNumber=int.Parse(Console.ReadLine()??"");

int Factorial()
{
    int proiz=1;
    int i=1;
    while(i<inputNumber+1)
    {
        proiz=proiz*i;
        i++;
    }
    return proiz;
}

Console.WriteLine(Factorial());
