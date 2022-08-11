//метод возвращает массив, заполненный случайными цфрами от -9 до 9
int[] FillingArray()
{
    int[] outArray=new int[12];
    int i=0;
    System.Random numberSintezator=new System.Random();
    while(i<12)
    {
        outArray[i]=numberSintezator.Next(-9,10);
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
//Метод инвертирует элементы массива 
int[] CalculateTask(int[] inputArray)
{
    int[] outputArray=new int[12];
    int i=0;
    System.Random numberSintezator=new System.Random();
    while(i<12)
    {
        outputArray[i]=inputArray[i]*(-1);
        i++;
    }
    return outputArray;
}



int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("");
int[] resultArray=CalculateTask(bufferArray);
PrintIntArray(resultArray);