// Задайте двумерный массив из целых чисел. Найдите ср арифметическое элементов в каждом столбце

int[,] FillingTwoDimArray(int countRow, int countColumn)
{
    int[,] outArray=new int[countRow, countColumn];
    int i=0; int j=0;
    System.Random numberSintezator=new System.Random();
    while(i<countRow)
    {
        j=0;
        while(j<countColumn)
            {outArray[i,j]=numberSintezator.Next(0, 10);
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


//Метод печатает среднее значение каждого столбца
void PrintMeanColumn(int[,] inputArray)
{
    int i=0; int j=0; int sum=0;
    while(j<inputArray.GetLength(1))
    {
        i=0;
        sum=0;
        while(i<inputArray.GetLength(0))
        {
            sum=sum+inputArray[i,j];
            i++;            
        }
        Console.Write(Math.Round((double)sum/inputArray.GetLength(0),1)+"\t");
        j++;
    }
}

int[,] array=FillingTwoDimArray(3, 4);
PrintTwoDimArray(array);
PrintMeanColumn(array);

