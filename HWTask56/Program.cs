//58// Задайте 2 матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

//Создание массива, где элементы получены путем перемножения элементов входящих массивов
int[,] UnionArray(int[,] inputOneArray, int[,] inputTwoArray)
{   
    int[,] outArray=new int[inputOneArray.GetLength(0), inputOneArray.GetLength(1)];
    if(inputOneArray.GetLength(0)==inputTwoArray.GetLength(0)&&
    inputOneArray.GetLength(1)==inputTwoArray.GetLength(1))
    {
        for(int i=0;i<inputOneArray.GetLength(0);i++)
        {
            for(int j=0;j<inputOneArray.GetLength(1);j++)
            {
                outArray[i,j]=inputOneArray[i,j]*inputTwoArray[i,j];
            }
            Console.Write("\n");
        }
        return outArray;
    }
    else Console.WriteLine("Это нельзя перемножить");
    return outArray;
}

int[,] oneArray=FillingTwoDimArray(4, 4);
PrintTwoDimArray(oneArray);
Console.Write("\n");
int[,] twoArray=FillingTwoDimArray(4, 4);
PrintTwoDimArray(twoArray);
Console.Write("\n");
int[,] unionArray=UnionArray(oneArray, twoArray);
PrintTwoDimArray(unionArray);