//В прямоугольной матрице найти строку с наименьшей суммой элементов.


int [,] Array = new int [8,8];
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i,j] = new Random().Next(20);
        Console.Write(Array[i,j] + " ");
    }
    Console.WriteLine();
}

int Siba (int[,] matr)
{
    int [] Murray = new int [matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           Murray[i] = Murray[i] + matr [i,j];
        }
        Console.Write(Murray[i] + " ");
    }
    int min = Murray[0];
    int minI = 0;
    for (int i = 0; i < Murray.Length; i++)
    {
        if (Murray[i] < min)
        {
            min = Murray[i];
            minI = i;
        }
    }
    Console.WriteLine();
    return minI;
}
Console.WriteLine();
Console.WriteLine(Siba(Array) + 1);