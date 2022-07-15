Console.WriteLine("Введите  номер:");
string? inputLkneNumber=Console.ReadLine();
string [] dayOfWeek=new string[7];
dayOfWeek[0]="Пн";
dayOfWeek[1]="Вт";
dayOfWeek[2]="Ср";
dayOfWeek[3]="Чт";
dayOfWeek[4]="Пт";
dayOfWeek[5]="Сб";
dayOfWeek[6]="Вс";

if (inputLkneNumber!=null)
{
    int inputNumber=int.Parse(inputLkneNumber);

    Console.WriteLine(dayOfWeek[inputNumber-1]);

}


//switch(inputNumber)
// {
//    case1:
//    Console.WriteLine("monday");
//    break;

//    case2:
//    Console.WriteLine("");
//    break;
// }