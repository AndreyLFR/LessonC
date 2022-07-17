Console.WriteLine("Введите  число 1:");
string? inputOneNumber=Console.ReadLine();
Console.WriteLine("Введите  число 2:");
string? inputTwoNumber=Console.ReadLine();

if(inputOneNumber!=null && inputTwoNumber!=null)
{
    int oneNumber=int.Parse(inputOneNumber);
    int twoNumber=int.Parse(inputTwoNumber);
    int oneNumberAbs=oneNumber*oneNumber;
    int twoNumberAbs=twoNumber*twoNumber;

    if(twoNumberAbs==oneNumber)
    {
        Console.WriteLine("1 квадрат 2");
    }
    else{
        Console.WriteLine("1 не квадрат 2");
    }
    if(oneNumberAbs==twoNumber)
    {
        Console.WriteLine("2 квадрат 1");
    }
    else{
        Console.WriteLine("2 не квадрат 1");
    }
}