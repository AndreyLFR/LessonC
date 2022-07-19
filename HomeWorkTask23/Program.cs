void printCube(int j)
{
    int cubeNumber = j * j * j;
    Console.Write(cubeNumber);
    Console.Write(", ");

}

int number = int.Parse(Console.ReadLine());

for (int i = 1; i < number + 1; i++)
{
    printCube(i);
}
