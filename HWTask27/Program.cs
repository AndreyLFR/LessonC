// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
//со * оценка времени алгоритма
Console.Write("Введите число: ");
string numbLine=Console.ReadLine()??"";

int SumChar(string numbL)
{
    char [] array=numbL.ToCharArray();
    int arrayLength=array.Length;
    int sum=0;
    for(int i=0;i<arrayLength;i++)
    {
        int arrI=array[i]-'0';
        sum=sum+arrI;
    }
    return sum;
}

int SumMat(string numbL)
{
    int number=int.Parse(numbL);
    int sum=0;
    while(number/10>0)
    {
        int modulo=number%10;
        number=number/10;
        sum=sum+modulo;
    }
    sum=sum+number;
    return sum;
}

DateTime t=DateTime.Now;
int sumChar=SumChar(numbLine);
Console.WriteLine("Метод через массив: "+sumChar);
Console.WriteLine(DateTime.Now-t);

t=DateTime.Now;
int sumMat=SumMat(numbLine);
Console.WriteLine("Метод через мат вычисления: "+sumMat);
Console.WriteLine(DateTime.Now-t);