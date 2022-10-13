int ReadNumber(string message) 
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
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


int line = ReadNumber("Введите количество строк: ");
int column = ReadNumber("Введите количество столбцов: ");

int[,] array1 = GetMatrix(line, column);
int[,] array2 = GetMatrix(line, column);

if (array1.GetLength(0) != array2.GetLength(1))  
{
    Console.WriteLine("Произведение матриц, не возможно!");
    return;
}

int[,] finalArray = new int[line, column];

for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            finalArray[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                finalArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

Console.WriteLine("Первая матрица: ");
PrintMatrix(array1);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintMatrix(array2);
Console.WriteLine();
Console.WriteLine("Массив с произведением двух матриц: ");
PrintMatrix(finalArray);