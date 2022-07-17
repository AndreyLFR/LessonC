Console.WriteLine("Введите трехзначное число: ");
string? input=Console.ReadLine();

//вариант через индекс массива
int Variant1(string number)
{
char[] arr = number.ToCharArray();
if (arr.Length>2)
    {int numberThree=arr[2]-48;
    return numberThree;}
else{
    int e=-1;
    return e;
}
}

try
{
int findNumber=Variant1(input);

if (findNumber==-1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
    {Console.WriteLine(findNumber);
    }
}
catch
//если input==null, то идем сюда
{
    Console.WriteLine("Возникло исключение!");
}
