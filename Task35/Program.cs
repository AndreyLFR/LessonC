//метод возвращает массив, заполненный случайными цфрами
int[] FillingArray()
{
    int[] outArray=new int[123];
    int i=0;
    System.Random numberSintezator=new System.Random();
    while(i<123)
    {
        outArray[i]=numberSintezator.Next(-1000, 1000);
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

//Метод определяет кол-во элементов в диапазоне от до
int CalculateTask(int[] inputArray, int downBorder, int upBorder)
{
    int resultCount=0;
    int i=0;
    while(i<inputArray.Length)
    {
        if(inputArray[i]>=downBorder&&inputArray[i]<=upBorder)
        {
            resultCount=resultCount+1;
        }
        i++;
    }
    return resultCount;
}


int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("");
int resultCount=CalculateTask(bufferArray, 10, 99);
Console.WriteLine(resultCount);