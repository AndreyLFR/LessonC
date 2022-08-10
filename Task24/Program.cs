Console.Write("Введите число: ");

int inputNumber=int.Parse(Console.ReadLine());
int t;

void VariantSimple()
{
    int sumOfNumber=0;
    for(int i=1;i<=inputNumber;i++)
    {
        sumOfNumber+=i;
    }
Console.WriteLine("Сумма чисел от 1 до "+inputNumber+" :"+sumOfNumber);
} 

void VariantGauss()
{
    int sumOfNumber=0;
    sumOfNumber=(1+inputNumber)*inputNumber/2;
    Console.WriteLine("Сумма чисел от 1 до "+inputNumber+" :"+sumOfNumber);
}

t=Environment.TickCount;
VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount-t);
t=Environment.TickCount;
VariantGauss();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount-t);