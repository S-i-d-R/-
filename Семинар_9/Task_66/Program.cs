int ReadNumber(string message)  
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int M = ReadNumber("Введите первое число: ");
int N = ReadNumber("Введите второе число: ");

void SummElements(int m, int n, int sum)
{   
    if(m < 0 || n < 0)
    {
        Console.WriteLine("Введено не натуральное число!"); 
        return;
    }
    if(m > n) 
    {
        Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N}, равно: {sum}"); 
        return;
    }
    sum = sum + (m++);
    SummElements(m, n, sum);
}

SummElements(M, N, 0);