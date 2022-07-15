System.Random numberSintezator=new Random();

void variant1(System.Random numberSintezator)
{
    int number=numberSintezator.Next(10, 100);

    int firstNumber=number/10;
    int secondNumber=number%10;

    Console.WriteLine(number);
    if(firstNumber>secondNumber)
    { Console.WriteLine(firstNumber);
    }
    else{
        Console.WriteLine(secondNumber);
    }
}
//Вариант3

void variant3(System.Random numberSintezator)
{
char[] digits=numberSintezator.Next(10,100).ToString().ToCharArray();

int firstNumberVVV=((int)digits[0])-48;
int secondNumberVVV=((int)digits[1])-48;

int resultNumber = firstNumberVVV>secondNumberVVV?resultNumber=firstNumberVVV:resultNumber=secondNumberVVV;

Console.WriteLine(digits);
Console.WriteLine(resultNumber);
}

variant3(numberSintezator);
