System.Random numberSintezator=new Random();

int arrLength=12;
int downNumber=-9;
int upNumber=9;
int sumPoz=0;
int sumNeg=0;

void GenArray()
{
    int i=0;
    Console.Write("[");
    while(i<arrLength-1)
    {
        int numb=numberSintezator.Next(downNumber,upNumber+1);
        if(numb>0)
        {sumPoz=sumPoz+numb;}
        else{sumNeg=sumNeg+numb;}

        Console.Write(numb);
        Console.Write(",");
        i++;
    }
    
    int numberFinish=numberSintezator.Next(downNumber,upNumber+1);
    if(numberFinish>0)
        {sumPoz=sumPoz+numberFinish;}
        else{sumNeg=sumNeg+numberFinish;}
    Console.Write(numberFinish);
    Console.Write("]");
    Console.Write("Сумма пол значений "+sumPoz+". Сумма отр значений "+sumNeg);
}


GenArray();
