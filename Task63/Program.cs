int ReadData()
{
    Console.WriteLine("Введите число N : ");
    return int.Parse(Console.ReadLine()??"");
}

int NumberPrint(int num)
{
    if(num==2) return 1;
    else
    {
        num--;
        Console.Write(NumberPrint(num)+" ");
    }
    return num;
}

int inputNumber=ReadData();
NumberPrint(inputNumber);