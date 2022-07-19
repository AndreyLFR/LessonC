void printSqr(int j)
{
    int sqrNumber = j * j;
    Console.Write(sqrNumber);
    Console.Write(", ");

}

int number = int.Parse(Console.ReadLine());

for (int i = 1; i < number + 1; i++)
{
    printSqr(i);
}
