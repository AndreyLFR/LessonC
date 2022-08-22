//56// ПЕРЕПУТАЛ НОМЕРА ЗАДАЧ. В Task56 решение 58 задачи, здесь 56
//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов 

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

//Метод осуществляет поиск строки с минимальной суммой элементов
int SearchRowMinSumElements(int[,] inputArray)
{
    int minSum=int.MaxValue;
    int indexRow=0;
    for(int i=0;i<inputArray.GetLength(0);i++)
    {
        int sumRow=0;
        for(int j=0;j<inputArray.GetLength(1);j++)
        {
            sumRow+=inputArray[i,j];
        }
        if(minSum>sumRow)
        {
            minSum=sumRow;
            indexRow=i;
        }
    }
    return indexRow;
}

int[,] twoDimArray=FillingTwoDimArray(6,4);
PrintTwoDimArray(twoDimArray);
Console.WriteLine(SearchRowMinSumElements(twoDimArray)+1+" строка");
