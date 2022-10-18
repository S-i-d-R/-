int ReadNumber(string message) 
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int m = ReadNumber("Введите первое  число: ");
int n = ReadNumber("Введите второе число: ");

int FunctionAkkerman(int m, int n) 
{
   if(n < 0 || m < 0)
    {
        Console.WriteLine("Введено не положительное число!");
        return 0;
    }
    if(m == 0) 
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m , n - 1));
    }
}

void Akkerman(int m, int n)  
{   
    Console.WriteLine();
    Console.Write($"Функция Аккермана равна: ");
    Console.WriteLine(FunctionAkkerman(m, n));
}

Akkerman(m, n);