// все натуральные числа от m до n

int ReadData(string namePeremenay)
{
    Console.WriteLine("Введите число "+namePeremenay+": ");
    return int.Parse(Console.ReadLine()??"");
}

void NaturNumberPrint(int m, int n)
{
    if(m==n) return;
    else
    {
        Console.Write(m+" ");
        NaturNumberPrint(m+1, n);        
    }
}

int m=ReadData("M");
int n=ReadData("N");
NaturNumberPrint(m, n);