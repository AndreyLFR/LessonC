Console.WriteLine("Введите число N=");
string? inputLkneNumber=Console.ReadLine();
int start=2;

if(inputLkneNumber!=null)
{
    int n=int.Parse(inputLkneNumber);
    int finish=n+1;
    
    while(start<finish)
    {
        Console.WriteLine(start); 
        start=start+2;
    }
}
