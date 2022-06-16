//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная).

int[,] Replace(int [,] matr)
{    
    int temp = 0;
    if (matr.GetLength(0) == matr.GetLength(1))
    {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i; j < matr.GetLength(1); j++)
        {
            temp = matr[i,j];
            matr[i,j] = matr[j,i];
            matr[j,i] = temp;
        }
    }
    return matr;
    }
    else 
    {
        Console.WriteLine("Матрица не квадратная");
        return matr;
    }
}
int [,] Array = new int [5,5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Array[i,j] = new Random().Next(50);
        Console.Write(Array[i,j] + " ");
    }
Console.WriteLine();
}

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
Console.WriteLine();
PrintArray(Replace(Array));