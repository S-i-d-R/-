int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix(int rowsCount, int columnCount, int leftRange = -50, int rightRange = 50)
{
    double[,] matrix = new double[rowsCount, columnCount];
    Random rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble() * (rightRange - leftRange) + leftRange;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2}   ");
        }
        Console.WriteLine();
    }
}


int m = ReadNumber("Введите колличество строк: ");
int n = ReadNumber("Введите колличество столбцов: ");
double[,] matr = GetMatrix(m, n);
PrintMatrix(matr);