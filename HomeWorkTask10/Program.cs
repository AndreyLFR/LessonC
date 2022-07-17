Console.WriteLine("Введите трехзначное число: ");
string? input=Console.ReadLine();

//вариант через индекс массива
int Variant1(string number)
{
char[] arr = number.ToCharArray();
if (arr.Length==3)
    {int numberThree=arr[2]-48;
    return numberThree;}
else{
    Console.WriteLine("Введите трехзначное число: ");
    int e=-1;
    return e;
}
}
//Вариант через остаток от деления
int Variant2(string number)
{
int numberInt=int.Parse(number);
if (numberInt>99 && numberInt>1000)
    {int div=numberInt%10;
    return div;}
else
    {Console.WriteLine("Введите трехзначное число: ");
    int e=-1;
    return e;}
}

try
{
int findNumber=Variant1(input);
//int findNumber=Variant2(input);
Console.WriteLine(findNumber);
}
catch
//если input==null, то идем сюда
{
    Console.WriteLine("Возникло исключение!");
}