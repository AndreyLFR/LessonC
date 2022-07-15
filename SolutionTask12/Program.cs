Console.WriteLine("Введите  число 1:");
string? inputOneNumber=Console.ReadLine();
Console.WriteLine("Введите  число 2:");
string? inputTwoNumber=Console.ReadLine();

if(inputOneNumber!=null && inputTwoNumber!=null)
{
    int oneNumber=int.Parse(inputOneNumber);
    int twoNumber=int.Parse(inputTwoNumber);
    int c=twoNumber%oneNumber;
    Console.WriteLine(c);
    if(c==0)
    {
        Console.WriteLine("yes");
    }
    else{
        Console.WriteLine("no,  остаток"+c);
    }
}