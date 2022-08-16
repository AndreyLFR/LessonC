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

//заполнение массиваб где каждый элемент сумма n+m   строка+столбец
void UpdateTwoDimArray(ref int[,] inputArray)
{
    int i=2; int j=2;
    while(i<inputArray.GetLength(0))
    {
        j=2;
        while(j<inputArray.GetLength(1))
        {
            inputArray[i,j]=inputArray[i,j]*inputArray[i,j];
            j=j+2;            
        }
        i=i+2;
        Console.Write("\n");
    }
}
//массив цветов
ConsoleColor[] col=new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                    ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                                    ConsoleColor.Green, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                    ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.DarkGreen,
                                    ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};

//Метод печатает цветной массив
void PrintColorTwoDimArray(int[,] inputArray)
{
    int i=0; int j=0;
    while(i<inputArray.GetLength(0))
    {
        j=0;
        while(j<inputArray.GetLength(1))
        {
            Console.ForegroundColor=col[new System.Random().Next(0,16)];
            Console.Write(inputArray[i,j]+" ");
            Console.ResetColor();
            j++;            
        }
        i++;
        Console.Write("\n");
    }
}

int[,] twoDimArray=FillingTwoDimArray(5, 10);
PrintColorTwoDimArray(twoDimArray);
UpdateTwoDimArray(ref twoDimArray);
PrintColorTwoDimArray(twoDimArray);
