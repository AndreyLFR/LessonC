// Задайте двумерный массив размером mxn, заполненный случайными вещественными числами
//изменение цвета цифр в элементах массива

//массив цветов
ConsoleColor[] col=new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                    ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                                    ConsoleColor.Green, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                    ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.DarkGreen,
                                    ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.Red, ConsoleColor.Yellow};

string[,] CreateTwoDimArray(int countRow, int countColumn)
{
    string[,] outArray=new String[countRow, countColumn];
    System.Random numberSintezator=new System.Random();
    for(int i=0;i<countRow;i++)
    {
        for(int j=0;j<countColumn;j++)
        {
            double number=numberSintezator.NextDouble();
            double numberOkr=Math.Round(number,4);
            outArray[i,j]=numberOkr.ToString();
        }
    }
    return outArray;
}

void PrintTwoDimArrayString(string[,] inputArray)
{
    for(int i=0;i<inputArray.GetLength(0);i++)
    {
        for(int j=0;j<inputArray.GetLength(1);j++)
        {
            Console.Write(inputArray[i,j]+"\t");
        }
    Console.Write("\n");
    }
}

void PaintTwoDimArray(string[,] inputArray)
{
    for(int i=0;i<inputArray.GetLength(0);i++)
    {
        for(int j=0;j<inputArray.GetLength(1);j++)
        {
            for(int m=0;m<inputArray[i,j].Length;m++)
            {
                Console.ForegroundColor=col[new System.Random().Next(0,16)];
                Console.Write(inputArray[i,j][m]);
                Console.ResetColor();
            }
            Console.Write("\t");
        }
    Console.Write("\n");
    }
}

string[,] blackArray=CreateTwoDimArray(3,4);
PrintTwoDimArrayString(blackArray);
PaintTwoDimArray(blackArray);
