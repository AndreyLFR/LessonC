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

//Транспонирование массива
int[] TransArray(int[] inputArray)
{
    int[] resultArray=new int[inputArray.Length];
    for(int i=0;i<inputArray.Length;i++)
    {
        resultArray[inputArray.Length-i-1]=inputArray[i];
    }
    return resultArray;
}
//Переворачиваем массив
int[] ReversArray(int[] inputArray)
{
    for(int i=0;i<inputArray.Length/2;i++)
    {
        int startElm=inputArray[i];
        inputArray[i]=inputArray[inputArray.Length-1-i];
        inputArray[inputArray.Length-1-i]=startElm;
    }
    return inputArray;
}

int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("");
int[] resultArray=TransArray(bufferArray);
Console.WriteLine(string.Join(',', resultArray));
int[] resultArraySvop=ReversArray(bufferArray);
Console.WriteLine(string.Join(',', resultArraySvop));