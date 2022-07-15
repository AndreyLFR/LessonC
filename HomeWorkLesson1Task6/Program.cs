Console.WriteLine("Введите число: ");
string? inputLkneNumber=Console.ReadLine();

if(inputLkneNumber!=null)
{
    int number=int.Parse(inputLkneNumber);
    int resultDivision=number%2;

        if(resultDivision==0)
        {
            Console.WriteLine("Введенное число - четное");            
        }
        else{
            Console.WriteLine("Введенное число - нечетное"); 
        }
}