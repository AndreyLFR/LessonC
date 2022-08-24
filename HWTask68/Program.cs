// 68// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа.
int ReadLine(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()??"");
}

int FuncAkkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FuncAkkerman(n - 1, 1);
    else
      return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1));
}

int m=ReadLine("Введите число m: ");
int n=ReadLine("Введите число n: ");
Console.WriteLine(FuncAkkerman(n, m));
