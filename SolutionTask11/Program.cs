
System.Random numberSintezator=new Random();
char[] digits=numberSintezator.Next(100,999).ToString().ToCharArray();

int firstNumber=((int)digits[0])-48;
int threeNumber=((int)digits[2])-48;

Console.WriteLine(digits);
Console.Write(firstNumber);
Console.Write(threeNumber);