//Метод считывает точки и возвращает массив с ними
int[,] readPoint()
{
    string inputline = Console.ReadLine();

    //A(3,6,8);B(2,1,-7) -> 15.84

    string coorALine = inputline.Substring(0, inputline.IndexOf(";"));
    //A(3,6,8)
    string coorAXMessy = coorALine.Substring(coorALine.IndexOf("(") + 1);
    string coorAX = coorAXMessy.Substring(0,coorAXMessy.IndexOf(","));
    string coorAYMessy = coorALine.Substring(coorALine.IndexOf(",") + 1);
    string coorAY=coorAYMessy.Substring(0, coorAYMessy.IndexOf(","));
    string coorAZMessy = coorAYMessy.Substring(coorAYMessy.IndexOf(",")+1);
    string coorAZ = coorAZMessy.Substring(0,coorAZMessy.IndexOf(")"));

    string coorBLine = inputline.Substring(inputline.IndexOf(";"));
    //B(2,1,-7)
    string coorBXMessy = coorBLine.Substring(coorBLine.IndexOf("(") + 1);
    string coorBX = coorBXMessy.Substring(0,coorBXMessy.IndexOf(","));
    string coorBYMessy = coorBLine.Substring(coorBLine.IndexOf(",") + 1);
    string coorBY=coorBYMessy.Substring(0, coorBYMessy.IndexOf(","));
    string coorBZMessy = coorBYMessy.Substring(coorBYMessy.IndexOf(",")+1);
    string coorBZ = coorBZMessy.Substring(0,coorBZMessy.IndexOf(")"));

    int coorXPointA = int.Parse(coorAX);
    int coorYPointA = int.Parse(coorAY);
    int coorZPointA = int.Parse(coorAZ);

    int coorXPointB = int.Parse(coorBX);
    int coorYPointB = int.Parse(coorBY);
    int coorZPointB = int.Parse(coorBZ);

    int[,] arrayOut = new int[2, 3];
    arrayOut[0, 0] = coorXPointA;
    arrayOut[0, 1] = coorYPointA;
    arrayOut[0, 2] = coorZPointA;

    arrayOut[1, 0] = coorXPointB;
    arrayOut[1, 1] = coorYPointB;
    arrayOut[1, 2] = coorZPointB;

    return arrayOut;
}

//вычисляет расстояние между точками
void conculateLengthAB(int[,] arreyPoint)
{
    double lengthAB = Math.Sqrt(Math.Pow((arreyPoint[0, 0] - arreyPoint[1, 0]), 2) + Math.Pow((arreyPoint[0, 1] - arreyPoint[1, 1]), 2) + Math.Pow((arreyPoint[0, 2] - arreyPoint[1, 2]), 2));
    double lengthTwoSing=Math.Round(lengthAB,2);
    
    Console.WriteLine(lengthTwoSing);
}

try
{
    int[,] arreyPoint = readPoint();
    conculateLengthAB(arreyPoint);
}
catch
//если input==null, то идем сюда
{
    Console.WriteLine("Возникло исключение!");
}
