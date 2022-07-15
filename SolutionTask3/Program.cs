Console.WriteLine("Введите  номер:");
string? inputLkneNumber=Console.ReadLine();

if(inputLkneNumber!=null)
{
    int n=int.Parse(inputLkneNumber);
    int start=(-1*n);
    string lineOut="";

    while(start<n)
    {
        lineOut=lineOut+start+", ";
        start++;       
    }
    lineOut=lineOut+n;
    Console.WriteLine(lineOut);
}



