//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива

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
int [,] SortArray(int [,] Matrix)
{   
    int temp = 0;
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1) -1; j++)
        {
           for (int k = 0; k < Matrix.GetLength(1)-1; k++)
           {
               if (Matrix[i,k] < Matrix[i,k+1])
              {  
               temp = Matrix[i,k];
               Matrix[i,k] = Matrix[i,k+1];
               Matrix[i,k+1] = temp;
              }
           }
        }
    }
    return Matrix;
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
PrintArray(SortArray(Array));