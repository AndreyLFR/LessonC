string? input = Console.ReadLine();

//Проверка через массив, работает при любом количестве элементов
void VariantArray(string text)
{
    int lenght = text.Length;
    int count = lenght / 2;
    //цикл будет перебирать от 0 элемента до середины строки
    for (int i = 0; i < count; i++)
    {
        if (text[i] != text[lenght - 1 - i])
        {
            Console.WriteLine("Вариант1: нет");
            break;
        }
        else
        {
            if (i == count - 1)
                Console.WriteLine("Вариант1: да");
        }
    }
}

void VariantMaths(string text)
{
    int number = int.Parse(text);

    int numberOne = number / 10000;
    int numberTwo = (number / 1000) % 10;
    int numberFour = (number / 10) % 10;
    int numberFive = number % 10;

    if (numberOne == numberFive && numberTwo == numberFour)
    {
        Console.WriteLine("Вариант2: да");
    }
    else
    {
        Console.WriteLine("Вариант2: нет");
    }
}

try
{
    VariantArray(input);
    VariantMaths(input);
}
catch
//если input==null, то идем сюда
{
    Console.WriteLine("Возникло исключение!");
}
