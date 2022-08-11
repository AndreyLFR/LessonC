// Задайте массив заполнения случайными числами. 
//Посчитать сумму элементов, стоящих на нечетных позициях
//*найдите все пары в массиве и выведите пользователю

//метод возвращает массив, заполненный случайными цфрами
int[] FillingArray()
{
    int[] outArray=new int[10];
    int i=0;
    System.Random numberSintezator=new System.Random();
    while(i<10)
    {
        outArray[i]=numberSintezator.Next(1, 10);
        i++;
    }
    return outArray;
}
//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    int i=0;
    while(i<inputArray.Length-1)
    {
        Console.Write(inputArray[i]+", ");
        i++;
    }
    Console.Write(inputArray[i]);
}

//Посчитать сумму элементов, стоящих на нечетных позициях
int CalculateTask(int[] inputArray)
{
    int resultSum=0;
    for(int i=1;i<inputArray.Length;i=i+2)
    {
        resultSum=resultSum+inputArray[i];
    }
    return resultSum;
}

//Поиск пар
void SearchPar(int[] inputArray)
{
    for(int i=0;i<inputArray.Length;i++)
    {
        for(int j=i+1;j<inputArray.Length;j++)
        {
            if(inputArray[i]==inputArray[j])
            {
                Console.WriteLine("Найдены пары "+inputArray[i]+". Позиции "+i+" и "+j);
            }
        }
    }
}

int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);
int resultSum=CalculateTask(bufferArray);
Console.WriteLine("");
Console.WriteLine("Сумма элементов на нечетных позициях "+resultSum);
SearchPar(bufferArray);
