// Напишите программу, которая на вход принимает ПОЗИЦИИ (в условиях примера задачи почему-то проверка элемента) элемента в двумерном массиве 
//и взвращает значение этого элемента или же указание об отсутствии элемента
//*заполнить массив числами фиббоначи
//*выделить цветом найденную цифру

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

//фиббоначи рекурсией
static int fib(int n)
{
  return n > 1 ? fib(n - 1) + fib(n - 2) : n;
}

//перезаписываю массив числами фиббоначи
int[,] FillingTwoDimArrayFibbonachi(int[,] inputArray)
{
    int countRow=inputArray.GetLength(0);
    int countColumn=inputArray.GetLength(1);    
    int[,] outArray=new int[countRow, countColumn];
    for(int i=0;i<countRow;i++)
    {
        for(int j=0;j<countColumn;j++)
        {
            int n=i*countColumn+j+1;
            outArray[i,j]=fib(n);
        }
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

//Метод печатает массив c выделением искомого элемента
void PrintArrayPaintSearchElement(int[,] inputArray, int numberRow, int numberColumn)
{
    if(numberRow<=inputArray.GetLength(0)&&numberColumn<=inputArray.GetLength(1))
    {

        int i=0; int j=0;
        while(i<inputArray.GetLength(0))
        {
            j=0;
            while(j<inputArray.GetLength(1))
            {
                if((i==numberRow-1)&&(j==numberColumn-1))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(inputArray[i,j]+"\t");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(inputArray[i,j]+"\t");
                }
                j++;            
            }
            i++;
            Console.Write("\n");
        }
    }
    else
    {
        Console.Write("Элемент не найден"+"\n");
    }
}

int[,] arrayRandom=FillingTwoDimArray(3, 4);
int[,] arrayFibbonachi=FillingTwoDimArrayFibbonachi(arrayRandom);
Console.Write("Массив заполнен случайными числами"+"\n");
PrintTwoDimArray(arrayRandom);
Console.Write("Массив заполнен числами Фиббоначи"+"\n");
PrintTwoDimArray(arrayFibbonachi);
Console.Write("Введите номер строки элемента, который следует найти:");
int numberRow=int.Parse(Console.ReadLine()??"");
Console.Write("Введите номер столбца элемента, который следует найти:");
int numberColumn=int.Parse(Console.ReadLine()??"");
Console.Write("Массив заполнен случайными числами"+"\n");
PrintArrayPaintSearchElement(arrayRandom, numberRow, numberColumn);
Console.Write("Массив заполнен числами Фиббоначи"+"\n");
PrintArrayPaintSearchElement(arrayFibbonachi, numberRow, numberColumn);
