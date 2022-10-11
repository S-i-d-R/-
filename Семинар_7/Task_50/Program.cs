int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GetMatrix(int rowsCount = 5, int columnCount = 5, int leftRange = -50, int rightRange = 50)
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

int line = ReadNumber("Введите номер строки позиции элемента в массиве: ");
int column = ReadNumber("Введите номер столбца позиции элемента в мпссиве: ");
int[,] matr = GetMatrix();
PrintMatrix(matr);
Console.WriteLine();
int number = 0;
if(line > matr.GetLength(0) || column > matr.GetLength(1))
{
    Console.WriteLine("Колличество введенных строк и столбцов не может превышать их колличество в массиве!");
}
else if(line <= 0 || column <= 0)
{
    Console.WriteLine("Колличество введенных строк и столбцов не может иметь отрицательное значение, или равняться нулю!");
}
else
{
    number = matr[line -1, column -1];
    Console.WriteLine($"Значение найденного элемента массива: {number}");
}