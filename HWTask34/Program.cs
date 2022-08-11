// Задайте массив заполнения случайными пол трехзначными числами. 
//Напишите программу, которая покажет количество четных чисел в массиве
//*сортировка методом пузырька - алгоритм писал сам, поэтому высока вероятность неоптимальной конструкции

//метод возвращает массив, заполненный случайными цфрами
int[] FillingArray()
{
    int[] outArray=new int[10];
    int i=0;
    System.Random numberSintezator=new System.Random();
    while(i<10)
    {
        outArray[i]=numberSintezator.Next(100, 1000);
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

//Определение количества четных числе в массиве
int CalculateTask(int[] inputArray)
{
    int i=0;
    int resultCount=0;
    while(i<inputArray.Length)
    {
        if(inputArray[i]%2==0)
        {resultCount++;}
        i++;
    }
    return resultCount;
}

//сортировка методом пузырьков
int[] ArraySortBubble(int[] inputArray)
{
    for(int j=0;j<inputArray.Length-1;j++)
    {
        for(int i=1;i<inputArray.Length-j;i++)
        {   
            int upNum=inputArray[i];
            int downNum=inputArray[i-1];
            if(upNum<downNum)
            {
                inputArray[i]=downNum;
                inputArray[i-1]=upNum;
            }
        }
    }
    return inputArray;
}

int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);
int resultCount=CalculateTask(bufferArray);
Console.WriteLine("");
Console.WriteLine("Количество четных чисел в массиве "+resultCount);
int[] arraySortBubble=ArraySortBubble(bufferArray);
Console.WriteLine(string.Join(',', arraySortBubble));
