Console.WriteLine ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result1 = number / 10;
    int result2 = result1 % 10;
    Console.WriteLine (result2);
}
else
{
   Console.WriteLine ("Вы ввели не трехзначное число!"); 
}