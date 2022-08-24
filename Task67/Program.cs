// сумма цифр введенного числа
int ReadData(string namePeremenay)
{
    Console.WriteLine("Введите число "+namePeremenay+": ");
    return int.Parse(Console.ReadLine()??"");
}

int Sum(int num)
{
    if(num>0) return num%10+Sum(num/10);
    else return 0;
}

int n=ReadData("N");
Console.WriteLine(Sum(n));