Console.WriteLine("Введите трехзначное число: ");
string? input=Console.ReadLine();

//вариант через индекс массива
int Variant1(string number)
{
char[] arr = number.ToCharArray();
int numberThree=arr[2]-48;
Console.WriteLine(numberThree);
return numberThree;
}
//Вариант через остаток от деления
int Variant2(string number)
{
int numberInt=int.Parse(number);
int div=numberInt%10;
return div;
}

try
{
//int findNumber=Variant1(input);
int findNumber=Variant2(input);
Console.WriteLine(findNumber);
}
catch
//если input==null, то идем сюда
{
    Console.WriteLine("Возникло исключение!");
}