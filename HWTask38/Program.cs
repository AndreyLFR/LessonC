// Задайте массив заполнения случайными числами. 
//Найдите разницу между максимальным и минимальным элементом массива
//*отсортируйте методом вставки и методом подсчета

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

//Поиск разницы между мак и мин
int CalculateTask(int[] inputArray)
{
    int max=0;
    int min=inputArray[0];
    for(int i=0;i<inputArray.Length;i++)
    {
        if(max<inputArray[i])
        {max=inputArray[i];}

        if(min>inputArray[i])
        {min=inputArray[i];}
    }
    return (max-min);
}

void SortVst(int[] inputArray){
	for(int i=1;i<inputArray.Length;i++){
		for(int j=i; j>0 && inputArray[j-1]>inputArray[j];j--){
			int tmp=inputArray[j-1];
			inputArray[j-1]=inputArray[j];
			inputArray[j]=tmp;
		}
	}
	Console.WriteLine(string.Join(',', inputArray));
}


int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);
int resultRaznost=CalculateTask(bufferArray);
Console.WriteLine("");
Console.WriteLine("Разность между макс и мин "+resultRaznost);
SortVst(bufferArray);


