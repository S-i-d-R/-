Console.WriteLine ("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = number;
int sum = 0;

if (number > 0)
{
while (i > 0)
{
sum = sum + i % 10;
i = i / 10;
}
Console.WriteLine($"Сумма цифр введенного числа: {sum}");
}
else
{
 Console.WriteLine("Вы ввели отрицательное число!");   
}