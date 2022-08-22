﻿// Составьте частотный словарь элементов двумерного массива.
//частотный словарь включает информацию о том сколько разстречается элемент входных данных
int[] FreqmancyCollect(int[,] inputArray)
{
    int[] resultArray=new int [11];
    int i=0; int j=0;
    while (i<inputArray.GetLength(0))
    {
        j=0;
        while (j<inputArray.GetLength(1))
        {
            //собираем частоту появления элементов
            resultArray[inputArray[i,j]]++;
            j++;
        }
        i++;
    }
    return resultArray;
}

int[,] FillingTwoDimArray(int countRow, int countColumn)
{
    int[,] outArray=new int[countRow, countColumn];
    int i=0; int j=0;
    System.Random numberSintezator=new System.Random();
    while(i<countRow)
    {
        j=0;
        while(j<countColumn)
            {outArray[i,j]=numberSintezator.Next(0, 11);
            j++;
            }
        i++;
    }
    return outArray;
}

//Метод печатает массив
void PrintTwoDimArray(int[,] inputArray)
{
    int i=0; int j=0;
    while(i<inputArray.GetLength(0))
    {
        j=0;
        while(j<inputArray.GetLength(1))
        {
            Console.Write(inputArray[i,j]+" ");
            j++;            
        }
        i++;
        Console.Write("\n");
    }
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


int[,] twoDimArray=FillingTwoDimArray(5, 5);
PrintTwoDimArray(twoDimArray);
int[] freqmancyCollect=FreqmancyCollect(twoDimArray);
PrintIntArray(freqmancyCollect);




