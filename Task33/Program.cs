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
//Метод проверяет наличие числа в массиве
bool CalculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch=false;
    int i=0;
    while(i<12)
    {
        if(inputArray[i]==searchNumber)
        {
            resultSearch=true;
            break;
        }
        i++;
    }
    return resultSearch;
}

Console.Write("Число для поиска ");
int number=int.Parse(Console.ReadLine()??"");
int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("");
bool resultSearch=CalculateTask(bufferArray, number);
Console.WriteLine(resultSearch);