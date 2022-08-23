//62//заполнить спирально массив 4 на 4 
int countSide=4;
int[,] outArray=new int[countSide,countSide];

void FillingSide(int i, int j, int count, int value, string route)
{
    int n=1; int x=0; int y=0; int nextCount=0;
    string nextRoute="";
    while(n<=count)
    {
        if(route=="right") 
        {
            outArray[i,j+n]=value;
            nextCount=count-1;
            nextRoute="down"; x=i; y=j+n;
        }
        if(route=="down") 
        {
            outArray[i+n,j]=value; 
            nextCount=count;
            nextRoute="left"; x=i+n; y=j; 
        }
        if(route=="left") 
        {
            outArray[i,j-n]=value;
            nextCount=count-1;
            nextRoute="up"; x=i; y=j-n; 
        }
        if(route=="up")
        {
            outArray[i-n,j]=value; 
            nextCount=count;
            nextRoute="right"; x=i-n; y=j; 
        }
        n++;
        value++;
    }
    if(nextCount-1>=0) FillingSide(x,y,nextCount,value,nextRoute);
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

FillingSide(0, -1, countSide, 1, "right");
PrintTwoDimArray(outArray);
