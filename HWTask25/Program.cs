// Напишите цикл, который принимает на вход два числа и возводит число А в натуральную степень В
int inputNumber(){
    Console.Write("Введите число: ");
    int numb=int.Parse(Console.ReadLine()??"");
    return numb;
}
int NumberPowCycle(int a, int b)
{
    int saveBlock=a;
    for(int i=2;i<=b;i++)
    {
        saveBlock=saveBlock*a;
    }
    return saveBlock;
}
double NumberPowMatc(int a, int b)
{
    double saveBlock=Math.Pow(a,b);
    return saveBlock;
}

int a=inputNumber();
int b=inputNumber();
if(b!=0){
    int numPowCycle=NumberPowCycle(a, b);
    double numPowMath=NumberPowMatc(a, b);
    Console.WriteLine("A в степени В: вариант цикл= "+numPowCycle+". вариант с мат формулой= "+numPowMath);
}
else
{
    Console.WriteLine("A в степени В= 1");
}

//Калькулятор
Console.WriteLine("КАЛЬКУЛЯТОР");
int numOne=inputNumber();
Console.Write("Введите знак (+, -, /, *, степень)  ");
string znak=Console.ReadLine()??"";
int numTwo=inputNumber();

if(znak=="степень")
{
    if(numTwo!=0){
    int numPowC=NumberPowCycle(numOne, numTwo);
    double numPowM=NumberPowMatc(numOne, numTwo);
    Console.Write("A в степени В: вариант цикл= "+numPowC+". вариант с мат формулой= "+numPowM);
    }
    else
    {
    Console.Write("A в степени В= 1");
    }
}
else
{
    if(znak=="+")
    {
        int summa=numOne+numTwo;
        Console.Write("Сумма= "+summa);
    }
    else{    
        if(znak=="-")
            {
                int raznost=numOne-numTwo;
                Console.Write("Разность= "+raznost);
            }
        else{
            if(znak=="*")
            {
                int proiz=numOne*numTwo;
                Console.Write("Произведение= "+proiz);
            }
            else{
                if(znak=="/")
                {
                int otn=numOne/numTwo;
                Console.Write("Отношение= "+otn);
                }
                else{
                   Console.Write("Введен некорректный знак"); 
                }
            }
            }}
    }