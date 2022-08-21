
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

//Метод печатает цветной массив
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
    int bufferElement=0; int j=0;
    while(j<inputArray.GetLength(1))
        {
            
            bufferElement=inputArray[0,j];
            inputArray[0,j]=inputArray[inputArray.GetLength(0)-1,j];
            inputArray[inputArray.GetLength(0)-1,j]=bufferElement;
            j++;            
        }
    return inputArray;
}


int[,] twoDimArray=FillingTwoDimArray(5, 5);
PrintTwoDimArray(twoDimArray);
Console.Write("\n");
int[,] twoDimArrayRotate=RotateRow(twoDimArray);
PrintTwoDimArray(twoDimArrayRotate);
