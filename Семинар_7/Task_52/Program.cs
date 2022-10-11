int[,] GetMatrix(int rowsCount = 5, int columnCount = 5, int leftRange = 0, int rightRange = 50)
{
    int[,] matrix = new int[rowsCount, columnCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}
int[,] array = GetMatrix();
PrintMatrix(array);
Console.WriteLine();
void ArithmeticMeanColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double a = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            a = array[i, j] + a;
        }
        Console.Write($"{a / array.GetLength(0)}  ");
    }
}
ArithmeticMeanColumn(array);