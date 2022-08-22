// удалит строку и столбец 2 мерного массива по наименьшому элементу
int[,] FillingTwoDimArray(int countRow, int countColumn)
{
    int[,] outArray=new int[countRow, countColumn];
    int i=0; int j=0;
    System.Random numberSintezator=new System.Random();
    while(i<countRow)
    {
        j=0;
        while(j<countColumn)
            {outArray[i,j]=numberSintezator.Next(0, 101);
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

int[] FindMinElement(int[,] inputArray)
{
    int[] array=new int[]{0,0};
    int minElement=int.MaxValue;

    for(int i=0;i<inputArray.GetLength(0);i++)
    {
        for(int j=0;j<inputArray.GetLength(1);j++)
        {
            if(inputArray[i,j]<minElement)
            {
                minElement=inputArray[i,j];
                array[0]=i;
                array[1]=j;
            }
        }
    }
    return array;
}

int[,] UpdateTwoDimArray(int[,] inputArray, int row, int column)
{
    int[,] outArray=new int[inputArray.GetLength(0)-1,inputArray.GetLength(1)-1];
    int i=0; int j=0;
    int k=0; int m=0;
    while(i<inputArray.GetLongLength(0))
    {
        j=0;
        m=0;
        while(j<inputArray.GetLength(1))
        {
            if(i!=row&&j!=column)
            {
                outArray[k,m]=inputArray[i,j];
            }
            j++;
            if(j!=column)m++;
        }
        i++;
        if(i!=row)k++;
    }
    return outArray;
}

int[,] twoDimArray=FillingTwoDimArray(5, 5);
PrintTwoDimArray(twoDimArray);
Console.Write("\n");
int[] indexes=FindMinElement(twoDimArray);
Console.Write(indexes[0]+"_"+indexes[1]);
Console.Write("\n");
int[,] updateArray=UpdateTwoDimArray(twoDimArray, indexes[0], indexes[1]);
PrintTwoDimArray(updateArray);
