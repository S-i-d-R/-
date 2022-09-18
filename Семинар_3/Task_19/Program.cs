Console.WriteLine ("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int number1 = number / 10000;
    int number2 = (number / 1000) % 10;
    int number4 = (number / 10) % 10;
    int number5 = number % 10;

    if (number1 == number5 & number2 == number4)
{
    Console.WriteLine ("Введенное число - это полиндром.");
}
    else
    {
            Console.WriteLine ("Введенное число - это НЕ полиндром.");
    }
}
else
{
   Console.WriteLine ("Вы ввели не пятизначное число!"); 
}