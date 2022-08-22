// 54// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//В ЗАДАЧЕ - по убыванию, в ПРИМЕРЕ - по возрастанию?????????

int[,] FillingTwoDimArray(int countRow, int countColumn)
{
    int[,] outArray=new int[countRow, countColumn];
    int i=0; int j=0;
    System.Random numberSintezator=new System.Random();
    while(i<countRow)
    {
        j=0;
        while(j<countColumn)
            {outArray[i,j]=numberSintezator.Next(1, 10);
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
            Console.Write(inputArray[i,j]+"\t");
            j++;            
        }
        i++;
        Console.Write("\n");
    }
}

//Метод сортировки 2мерного массива по возрастанию
int[,] InsertionSortRowTwoDimArray(int[,] inputArray)
{
    for(int i=0;i<inputArray.GetLength(0);i++)
    {
        for (int j = 1; j < inputArray.GetLength(1); j++)
        {
            int bufferElement = inputArray[i,j];
            int m = j;
            while (m > 0 && bufferElement < inputArray[i,(m - 1)])
            {
                inputArray[i,m] = inputArray[i,(m - 1)];
                m--;
            }
            inputArray[i,m] = bufferElement;
        }
    }
    return inputArray;
}

//Метод сортировки 2мерного массива по уменьшению
int[,] InsertionSortDownRowTwoDimArray(int[,] inputArray)
{
    for(int i=0;i<inputArray.GetLength(0);i++)
    {
        for (int j = 1; j < inputArray.GetLength(1); j++)
        {
            int bufferElement = inputArray[i,j];
            int m = j;
            while (m > 0 && bufferElement > inputArray[i,(m - 1)])
            {
                inputArray[i,m] = inputArray[i,(m - 1)];
                m--;
            }
            inputArray[i,m] = bufferElement;
        }
    }
    return inputArray;
}


int[,] twoDimArray=FillingTwoDimArray(4, 5);
PrintTwoDimArray(twoDimArray);
Console.Write("Сортировка по возрастанию \n");
int[,] twoDimArraSort=InsertionSortRowTwoDimArray(twoDimArray);
PrintTwoDimArray(twoDimArraSort);
Console.Write("Сортировка по убыванию \n");
int[,] twoDimArraSortDown=InsertionSortDownRowTwoDimArray(twoDimArray);
PrintTwoDimArray(twoDimArraSortDown);