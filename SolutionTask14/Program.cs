Console.WriteLine("Введите  число:");
string? inputOneNumber=Console.ReadLine();

if(inputOneNumber!=null)
{
    int oneNumber=int.Parse(inputOneNumber);

    int divOne=oneNumber%7;
    int divTwo=oneNumber%23;

    if(divOne==0 && divTwo==0)
    {
        Console.WriteLine("yes");
    }
    else{
        Console.WriteLine("no");
    }
}