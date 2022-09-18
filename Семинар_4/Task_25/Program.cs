int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadNumber("Введите положительное число A:");
int numberB = ReadNumber("Введите положительное число B:");

int i = numberB;
int result = 1;

if (numberA > 0 & numberB > 0)
{
for (i = numberB; i > 0; i--)
{
    result = result * numberA;
}
Console.WriteLine($"Результат: {result}");
}
else
{
 Console.WriteLine("Вы ввели отрицательное число!");   
}