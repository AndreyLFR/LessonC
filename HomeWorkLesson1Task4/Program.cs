Console.Write("Введите 1 целое число");
string? inputLkneOne=Console.ReadLine();
Console.Write("Введите 2 целое число");
string? inputLkneTwo=Console.ReadLine();
Console.Write("Введите 3 целое число");
string? inputLkneThree=Console.ReadLine();

if (inputLkneOne!=null && inputLkneTwo!=null && inputLkneThree!=null)
{
    int oneNumber=int.Parse(inputLkneOne);
    int twoNumber=int.Parse(inputLkneTwo);
    int threeNumber=int.Parse(inputLkneThree);

    if(oneNumber<twoNumber)
    {
        if(twoNumber<threeNumber)
        {
            Console.Write("max=");
            Console.Write(threeNumber); 
        }
        else
        {            
            Console.Write("max=");
            Console.Write(twoNumber);
        }
    }
    else
    {
        if(oneNumber<threeNumber)
        {
            Console.Write("max=");
            Console.Write(threeNumber); 
        }
        else
        {            
            Console.Write("max=");
            Console.Write(oneNumber);
        }
    }
}