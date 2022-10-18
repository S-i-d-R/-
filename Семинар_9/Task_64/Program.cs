int ReadNumber(string message)  
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNTo1(int n) 
{   
    if(n < 0)
    {
        Console.WriteLine("Число не натуральное!");
        return;
    }
    if(n == 0)
    {
        return;
    }
    else
    {   
        Console.Write(n + " ");
        PrintNTo1(n - 1);

    }
}

int numberN = ReadNumber("Введите число: ");
PrintNTo1(numberN);