// Возвести А в степень В
int PowNumber(int a, int b)
{
    if(b==0) return 1;
    return a*PowNumber(a,--b);
}

int AlternativePow(int a, int b)
{
    if(b==2) return a*a;
    if(b==1) return a;
    if(b%2==0)
    {
        return AlternativePow(a,b/2)*AlternativePow(a,b/2);
    }
    else
    {
        return AlternativePow(a,b/2)*AlternativePow(a,b/2)*a;
    }
}

int ReadData(string namePeremenay)
{
    Console.WriteLine("Введите число "+namePeremenay+": ");
    return int.Parse(Console.ReadLine()??"");
}

int a=ReadData("A");
int b=ReadData("B");
Console.WriteLine(PowNumber(a,b));