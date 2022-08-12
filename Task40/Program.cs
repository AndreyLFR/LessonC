int sideA=0;
int sideB=0;
int sideC=0;

void ReadSides()
{
Console.Write("Введите A: ");
sideA=int.Parse(Console.ReadLine()??"");
Console.Write("Введите B: ");
sideB=int.Parse(Console.ReadLine()??"");
Console.Write("Введите C: ");
sideC=int.Parse(Console.ReadLine()??"");
}

bool TestTriagle(int a, int b, int c)
{
    bool r;
    if((a+c>b)&&(a+b>c)&&(b+c>a))
    {
        r=true;
    }
    else
    {
        r=false;
    }
    Console.WriteLine(r);
    return r;
}

void PrintAnswer(bool result)
{
    if(result == true)
    {Console.WriteLine("можно");}
    else{
    Console.WriteLine("нельзя");}
}

ReadSides();
bool res=TestTriagle(sideA, sideB, sideC);
PrintAnswer(res);
