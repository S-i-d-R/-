Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remains = number % 2;

if (remains == 0)
{
 Console.WriteLine ("Ваше число четное");  
}
else
{
 Console.WriteLine ("Ваше число нечетное");
}