﻿//метод возвращает массив, заполненный случайными цфрами
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
int[] CalculateTask(int[] inputArray)
{
    int[] resultArray=new int[inputArray.Length/2+1];
    int i=0;

    while(i<resultArray.Length)
    {
        resultArray[i]=inputArray[i]*inputArray[inputArray.Length-1-i];
        i++;
    }
    return resultArray;
}


int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("");
int[] resultArray=CalculateTask(bufferArray);
Console.WriteLine(resultArray);