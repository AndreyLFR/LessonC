Console.WriteLine("Введите  номер:");
string? inputLkneNumber=Console.ReadLine();

if(inputLkneNumber!=null)
{
    int number=int.Parse(inputLkneNumber);
    int otatok=number%10;

    Console.WriteLine(otatok);
}
