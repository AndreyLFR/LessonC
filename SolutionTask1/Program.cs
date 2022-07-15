Console.WriteLine("Введите 1 число:");
string? inputLkneOne=Console.ReadLine();
Console.WriteLine("Введите 2 число:");
string? inputLkneTwo=Console.ReadLine();

if (inputLkneOne!=null && inputLkneTwo!=null)
{
    int inputOne=int.Parse(inputLkneOne);
    int inputTwo=int.Parse(inputLkneTwo);

    if(inputTwo==Math.Sqrt(inputOne))
    {
        Console.WriteLine("Верно");
    }
    else
    {
        Console.WriteLine("Неверно");
    }
}