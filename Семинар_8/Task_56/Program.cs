int[,] GetMatrix(int rowsCount, int columnCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnCount];
    Random rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange +1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}
void MinSummElement(int[,] array)
{
    int minSum = 0;
    int minLine = 0;
    int sumLine = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumLine += array[i, j];
        if (sumLine < minSum)
        {
            minSum = sumLine;
            minLine = i;
        }
        sumLine = 0;
    }
    Console.Write($"Строка номер {minLine + 1} с наименьшей суммой элементов, сумма элементов этой строки {minSum}.");
}


int[,] array = GetMatrix(3, 5);
PrintMatrix(array);
Console.WriteLine();
MinSummElement(array);