Console.Write("a=");
string? inputLkneOne=Console.ReadLine();
Console.Write("b=");
string? inputLkneTwo=Console.ReadLine();

if (inputLkneOne!=null && inputLkneTwo!=null)
{
    int a=int.Parse(inputLkneOne);
    int b=int.Parse(inputLkneTwo);

    if(a<b)
    {
        Console.Write("max=");
        Console.Write(b);
    }
    else
    {
        Console.Write("max=");
        Console.Write(a);
    }
}