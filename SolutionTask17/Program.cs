//Метод считывает точки и возвращает массив с ними

int[,] readPoint()
{
    string inputline=Console.ReadLine();

    //x=34;y=-30 -> 4

    string coorXLine=inputline.Substring(0,inputline.IndexOf(";"));
    coorXLine=coorXLine.Substring(coorXLine.IndexOf("=")+1);

    string coorYLine=inputline.Substring(inputline.IndexOf(";")+1);
    coorYLine=coorYLine.Substring(coorYLine.IndexOf("=")+1);

    int coordX=int.Parse(coorXLine);
    int coordY=int.Parse(coorYLine);

    int[,] arrayOut=new int[1,2];
    arrayOut[0,0]=coordX;
    arrayOut[0,1]=coordY;

    return arrayOut;
}

//Печатает номер четверти
void printQuter(int[,] arreyPoint)
{
    if(arreyPoint[0,0]>0&&arreyPoint[0,1]>0)
    Console.WriteLine("1");

    if(arreyPoint[0,0]<0&&arreyPoint[0,1]>0)
    Console.WriteLine("2");

    if(arreyPoint[0,0]<0&&arreyPoint[0,1]<0)
    Console.WriteLine("3");

    if(arreyPoint[0,0]>0&&arreyPoint[0,1]<0)
    Console.WriteLine("4");
}

int[,] arreyPoint=readPoint();
printQuter(arreyPoint);