// меняем строки на столбцы
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


int[,] RotateRow(int[,] inputArray)
{
    if(inputArray.GetLength(1)==inputArray.GetLength(0))
    {
        int bufferElement=0; int i=0; int j=0;
        while(i<inputArray.GetLength(0))
        {
            j=i;
            while(j<inputArray.GetLength(0))
            {
                bufferElement=inputArray[i,j];
                inputArray[i,j]=inputArray[j,i];
                inputArray[j,i]=bufferElement;
                j++;  
            }
            i++;
        }
    }
    else{
        Console.WriteLine("Кривой массив");
    }
    return inputArray;
}

int[,] twoDimArray=FillingTwoDimArray(5, 5);
PrintTwoDimArray(twoDimArray);
Console.Write("\n");
int[,] twoDimArrayRotate=RotateRow(twoDimArray);
PrintTwoDimArray(twoDimArrayRotate);
