// 60// Сформируйте 3мерный массив из неповторяющихся двухзначных чисел. Напишите программу , 
//которая будет построчно выводить массив, добавляя индексы каждого элемента
int oneIndex=2; int twoIndex=2; int threeIndex=2;
List<int> numbers = new List<int>(oneIndex*twoIndex*threeIndex);

int TestUnique()
{
    System.Random numberSintezator=new System.Random();
    int value=numberSintezator.Next(10, 100);
    if(numbers.Contains(value)) value=TestUnique();
    else numbers.Add(value);
    return value;
}

int[,,] FillingThreeDimArray(int oneIndex, int twoIndex, int threeIndex)
{
    int[,,] outArray=new int[oneIndex+1, twoIndex+1, threeIndex+1];
    for(int x=0;x<=oneIndex;x++) for(int y=0;y<=twoIndex;y++) for(int z=0;z<=threeIndex;z++) outArray[x,y,z]=TestUnique();
    return outArray;
}

//Метод печатает массив
void PrintThreeDimArray(int[,,] inputArray)
{
    for(int x=0;x<inputArray.GetLength(0);x++)
    {
        for(int y=0;y<inputArray.GetLength(1);y++)
        {
            for(int z=0;z<inputArray.GetLength(2);z++)
            {
                Console.Write(inputArray[x,y,z]+"("+x+","+y+","+z+")"+"\n");
            }   
        }
    }
}

int[,,] threeDimArray=FillingThreeDimArray(oneIndex,twoIndex,threeIndex);
PrintThreeDimArray(threeDimArray);
