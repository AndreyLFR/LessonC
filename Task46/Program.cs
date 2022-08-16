//метод возвращает двумерный массив, заполненный случайными цфрами
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

int[,] array=FillingTwoDimArray(5, 10);
PrintTwoDimArray(array);
