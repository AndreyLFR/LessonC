Console.WriteLine("Введите номер дня недели: ");
string? input=Console.ReadLine();

try
{
    int numberDay=int.Parse(input);
    if(numberDay==6||numberDay==7)
    {
        Console.WriteLine("Да");
    }
    else{
        Console.WriteLine("Нет");
    }
}
catch
//если input==null, то идем сюда
{
    Console.WriteLine("Возникло исключение!");
}
