//Написать программу, которая обменивает элементы первой строки и последней строки

int [,] Array = new int [3,5];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Array[i,j] = new Random().Next(50);
        Console.Write(Array[i,j] + " ");
    }
Console.WriteLine();
}
int [,] Revers(int [,] Matrix)
{
    int temp = 0;
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
       temp = Matrix[0,j];
       Matrix[0,j] = Matrix[Matrix.GetLength(0)-1,j];
       Matrix[Matrix.GetLength(0)-1,j] = temp;
    }
    return Matrix;
}
Console.WriteLine();
void PrintArray(int [,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0);i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write(Matrix[i,j] + " ");
        }
    Console.WriteLine();
    }
}
PrintArray(Revers(Array));