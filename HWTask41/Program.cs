// Пользователь вводит с клавиатуры М чисел. Посчитать, сколько чисел больше 0 ввел пользователь
//*Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено

int countNumber=5;

int[] Read(int count)
{
    int[] bufArray=new int[count];
    for(int i=0;i<count;i++)
    {
        Console.Write("Введите число: ");
        bufArray[i]=int.Parse(Console.ReadLine()??"");
    }
    return bufArray;
}

int Calculate(int[] inputArray)
{
    int amount=0;
    for(int i=0;i<inputArray.Length;i++)
    {
        if(inputArray[i]>0)
        {
            amount++;
        }
    }
    return amount;
}

//ниже методы для задачи со *(универсальное решение не смог допилить - решение сделал из предпосылки, что вводятся только числа через пробел)
int ReadPress(int amount)
{
    int hoarder_=1;
    int hoarderMinus=0;
    ConsoleKeyInfo key;
    for(int i=0;i<amount;i++)
    {                
        key=Console.ReadKey();
//        Console.WriteLine(key.KeyChar.ToString());
        if(key.KeyChar.ToString()==" ")
        {
            hoarder_++;
        }
        if(key.KeyChar.ToString()=="-")
        {
            hoarderMinus++;
        }
    }   
    int result=hoarder_-hoarderMinus;
    return result;
}


int[] resArray=Read(countNumber);
int amountPoz=Calculate(resArray);
Console.WriteLine("Кол-во пол значений: "+amountPoz);

//ниже ввод исла нажатий для задачи со *
Console.Write("Введите число нажатий для задачи со *: ");
int amountPres=int.Parse(Console.ReadLine()??"");
int amountPozPress=ReadPress(amountPres);
Console.WriteLine(" Кол-во пол значений: "+amountPozPress);


